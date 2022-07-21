using System;
using System.Data;
using System.Data.SqlClient;
using EncryptPassword35;
using Inventory_System.Model.Helper;

namespace Inventory_System.Model
{
     
    public class Users : IUsers
    {
       
        /// <summary>
        /// currently logged in user id
        /// </summary>
        public static string LoggedUserID { get; set; } 
        /// <summary>
        /// Currently pogged in user username
        /// </summary>
        public static string LoggedUsername { get; private set; }
        /// <summary>
        /// Currently logged in user password
        /// </summary>
        public static  string LoggedPassword { get; private set; }
        /// <summary>
        /// user id
        /// </summary>
        private string userID;

        public string UserID
        {
            get { return userID; }
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw  new Exception("userid cannot be empty");
                userID = value;
            }
        }

        private string newPassword;

        public string NewPassword
        {
            get { return newPassword; }
            set { newPassword = value; }
        }

        private string newUsername;

        public string Newusername
        {
            get { return newUsername; }
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new Exception("new username cannot be empty");
                newUsername = value;
            }
        }

        private string firstQuestion;

        public string FirstQuestion
        {
            get { return firstQuestion; }
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new Exception("Select first question");
                firstQuestion = value;
            }
        }

        private string firstAnswer;

        public string FirstAnswer
        {
            get { return firstAnswer; }
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw  new Exception("Enter Answer for first question");
                firstAnswer = value;
            }
        }
        private string secondQuestion;

        public string SecondQuestion
        {
            get { return secondQuestion; }
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new Exception("Select Second question");
                secondQuestion = value;
            }
        }
        private string secondAnswer;

        public string SecondAnswer
        {
            get { return secondAnswer; }
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new Exception("Enter answer for second question");
                secondAnswer = value;
            }
        }
        /// <summary>
        /// Check user status
        /// </summary>
        public static bool IsLoggedIn { get; private set; }
        /// <summary>
        /// Checks if login was succefull
        /// </summary>
        public bool IsLogin { get; private set; }
   
        /// <summary>
        /// User role for the user
        /// </summary>
        public static string Role { get; private set; } 
        public static int RoleID { get; private set; }
        public string newRole { get; set; }
        /// <summary>
        /// username for the new user
        /// </summary>
        public string Username { get; set; }
         /// <summary>
         /// reset currently logged in user password
         /// </summary>
         /// <param name="user"></param>
         /// <param name="loggedUserID"></param>
        public void ResetPassword(IUsers user, string loggedUserID)
        {
            try
            {
                  ISqlHelper myConHelper = Factory.CreateSqlConHelper();
                SqlCommand myconn = myConHelper.GetConnection().CreateCommand();
                var encryptPassword = SecurePassword.Encrypt(user.NewPassword);
               myconn.Parameters.AddWithValue("@userid", loggedUserID);
                myconn.Parameters.AddWithValue("@password", encryptPassword);
                myconn.CommandText = "sp_reset_password";
                myconn.CommandType = CommandType.StoredProcedure;
                myConHelper.Open();
                myconn.ExecuteNonQuery();
                myConHelper.Close();
                UserActivity.RecordActivity(string.Format("{0} Changed password ", Users.LoggedUsername));
                LoggedPassword = encryptPassword;
                IsLogin= IsLoggedIn = false;

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Change currently loged in username
        /// </summary>
        /// <param name="user"></param>
        /// <param name="loggedUserID"></param>
        public void ResetUsername(IUsers user,string loggedUserID)
        {
            try
            {
                  ISqlHelper myConHelper = Factory.CreateSqlConHelper();
                SqlCommand myconn = myConHelper.GetConnection().CreateCommand(); 
                myconn.Parameters.AddWithValue("@username", user.Newusername);
                myconn.Parameters.AddWithValue("@userid", loggedUserID);
                myconn.CommandText = "sp_reset_username";
                myconn.CommandType = CommandType.StoredProcedure;
                myConHelper.Open();
                myconn.ExecuteNonQuery();
                myConHelper.Close();
                UserActivity.RecordActivity(string.Format("{0} Changed username to {1}", Users.LoggedUsername, user.Username));
                LoggedUsername = user.Newusername;
                IsLogin= IsLoggedIn = false;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Rest Lost account details
        /// </summary>
        /// <param name="user"></param>
        public void ForgottonPassword(IUsers user)
        {
            try
            {
                  ISqlHelper myConHelper = Factory.CreateSqlConHelper();
                SqlCommand myconn = myConHelper.GetConnection().CreateCommand();
                
                    var encryptPassword = SecurePassword.Encrypt(user.NewPassword);
                
                    myconn.Parameters.AddWithValue("@username", user.Username);
                    myconn.Parameters.AddWithValue("@password", encryptPassword);
                    myconn.CommandType = CommandType.StoredProcedure;
                    myconn.CommandText = "sp_reset_forgotten_password";
                    myconn.CommandType = CommandType.StoredProcedure; 
                    myConHelper.Open();
                    myconn.ExecuteNonQuery();
                    myConHelper.Close();
                    LoggedPassword = encryptPassword;
                    IsLogin = IsLoggedIn = false;
                }
            
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


         
        public void Delete(IUsers user)
        {
            try
            {

                ISqlHelper myConHelper = Factory.CreateSqlConHelper();
                SqlCommand cmCommand = myConHelper.GetConnection().CreateCommand();
                cmCommand.Parameters.Clear();
                cmCommand.Parameters.AddWithValue("@userid", this.UserID); 
                cmCommand.Parameters.AddWithValue("@adminuser", LoggedUserID); 
                cmCommand.CommandText = "sp_delete_user";
                cmCommand.CommandType = CommandType.StoredProcedure;
                myConHelper.Open();
                cmCommand.ExecuteNonQuery();
                myConHelper.Close(); 

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
        /// <summary>
        /// Update user role
        /// </summary>
        public void UpdateRole()
        {
            try
            { 
                ISqlHelper myConHelper = Factory.CreateSqlConHelper();
                SqlCommand cmCommand = myConHelper.GetConnection().CreateCommand();
                cmCommand.Parameters.Clear();
                cmCommand.Parameters.AddWithValue("@userid", this.UserID);
                cmCommand.Parameters.AddWithValue("@role", Role); 
                cmCommand.Parameters.AddWithValue("@role", this.newRole);
                cmCommand.CommandText = "sp_update_staff";
                cmCommand.CommandType = CommandType.StoredProcedure;
                myConHelper.Open();
                cmCommand.ExecuteNonQuery();
                myConHelper.Close();
 

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
       
        public void ResetPassword(IUsers user)
        {

        }

        /// <summary>
        /// Login user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            try
            {
                  IsLogin = false; 
                    DataTable _table = new DataTable();
                    SqlDataAdapter _adapter = new SqlDataAdapter();
                    ISqlHelper sqlCon = Factory.CreateSqlConHelper();
                    SqlConnection con = sqlCon.GetConnection();
                    SqlCommand cmCommand = new SqlCommand("sp_user_login", con);
                    cmCommand.Parameters.Clear();
                    cmCommand.Parameters.AddWithValue("@username", username);
                    cmCommand.Parameters.AddWithValue("@password", SecurePassword.Encrypt(password));
                    cmCommand.CommandType = CommandType.StoredProcedure;
                    _adapter = new SqlDataAdapter(cmCommand);
                    con.Open();
                    _adapter.Fill(_table);
                    cmCommand.ExecuteNonQuery();
                    if (_table.Rows.Count > 0)
                    {
                        foreach (DataRow row in _table.Rows)
                        {
                            LoggedUserID = row["UserID"].ToString();
                            LoggedUsername = row["Username"].ToString();
                            LoggedPassword = row["Password"].ToString();
                            Role = row["Role"].ToString();
                            IsLogin= IsLoggedIn = true;
                        }
                    }
                    else
                    {
                        IsLogin= IsLoggedIn = false;
                    }

                    if (IsLogin)
                    {
                        if (SecurePassword.Encrypt(username) != SecurePassword.Encrypt(LoggedUsername))
                            return IsLogin = IsLoggedIn = false;
                        //SET PRIVILEDGE

                        SetPrivilege(Role);
                        IsLogin= IsLoggedIn = true;
                    }

                    return IsLogin; 
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
      
        /// <summary>
        /// Set the logged in user privilege level
        /// </summary>
        /// <param name="role"></param>
        private static void SetPrivilege(string role)
        {
            role = role.ToLower();
            if (role == "admin")
            {
                Users.RoleID = 1;
            }else if (role == "user")
            {
                Users.RoleID = 2;
            } 
            else
            {
                Users.RoleID = 0;
            }
            
            
        }
        
        /// <summary>
        /// check at first run of application
        /// if any user exists
        /// </summary>
        /// <returns></returns>
        public bool IfUsersExist()
        {
            try
            {
                DataTable _table = new DataTable();
                ISqlHelper sqlCon = Factory.CreateSqlConHelper();
                SqlConnection con = sqlCon.GetConnection();
                SqlCommand cmCommand = new SqlCommand("sp_users_exist", con);
                cmCommand.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataAdapter _adapter = new SqlDataAdapter(cmCommand);

                _adapter.Fill(_table);
                cmCommand.ExecuteNonQuery();
                if (_table.Rows.Count > 0)
                {
                    foreach (DataRow row in _table.Rows)
                    {
                        if (int.Parse(row["Count"].ToString()) > 0)
                            return true;
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + "\nuser Check failed");

            }
        }
        /// <summary>
        /// Find user account
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        protected internal string FindUserAccount(string search)
        {
            try
            {
                string foundID = null;
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection myconn = mySqlHelper.GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_find_user_account", myconn);
                    cmd.Parameters.AddWithValue("@username", search);
                    cmd.Parameters.AddWithValue("@password", SecurePassword.Encrypt( search));
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        DataRow row = table.Rows[0];
                        foundID = row["UserName"].ToString();

                    }

                    return foundID;

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
 
    }
}