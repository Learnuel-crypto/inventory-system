using Inventory_System.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using EncryptPassword35;
using Inventory_System.Model.Helper;

namespace Inventory_System.Models
{
    public class Staff
    {
        private SqlDataAdapter da;
        private DataTable _table;
        public string StaffID { get; set; }
        public string CNIC { get; set; }
        public string Contact { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        /// <summary>
        /// Register staff
        /// </summary>
        /// <param name="run">First time app is run</param>
        public void RegisterStaff(bool run)
        {
            try
            {
               
                ISqlHelper myConHelper = Factory.CreateSqlConHelper();
                SqlCommand cmCommand = myConHelper.GetConnection().CreateCommand();
                cmCommand.Parameters.Clear();
                cmCommand.Parameters.AddWithValue("@name", this.Name);
                cmCommand.Parameters.AddWithValue("@contact", this.Contact);
                cmCommand.Parameters.AddWithValue("@cnic", this.CNIC);
                cmCommand.Parameters.AddWithValue("@role", this.Role);
                cmCommand.Parameters.AddWithValue("@username", this.Username);
                cmCommand.Parameters.AddWithValue("@password", SecurePassword.Encrypt(this.Password));
                cmCommand.CommandText = "sp_register_staff";
                cmCommand.CommandType = CommandType.StoredProcedure;
                myConHelper.Open();
                cmCommand.ExecuteNonQuery();
                myConHelper.Close();
                if (run == false)
                {
                    UserActivity.RecordActivity("Registered a staff");
                }


            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Display and search staff
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        protected internal DataTable Display(string search)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_display_staff";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        protected internal DataTable GetAccountDetails()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@staffid", StaffID);
                myComand.CommandText = "sp_get_account_infor";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// update staff details
        /// </summary>
        public void UpdateStaff()
        {
            try
            {

                ISqlHelper myConHelper = Factory.CreateSqlConHelper();
                SqlCommand cmCommand = myConHelper.GetConnection().CreateCommand();
                cmCommand.Parameters.Clear();
                cmCommand.Parameters.AddWithValue("@name", this.Name);
                cmCommand.Parameters.AddWithValue("@contact", this.Contact);
                cmCommand.Parameters.AddWithValue("@cnic", this.CNIC);
                cmCommand.Parameters.AddWithValue("@staffid", this.StaffID);
                cmCommand.CommandText = "sp_update_staff";
                cmCommand.CommandType = CommandType.StoredProcedure;
                myConHelper.Open();
                cmCommand.ExecuteNonQuery();
                myConHelper.Close();
                UserActivity.RecordActivity("Update staff details");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteStaff(string loggedUserId)
        {
            try
            { 
                ISqlHelper myConHelper = Factory.CreateSqlConHelper();
                SqlCommand cmCommand = myConHelper.GetConnection().CreateCommand();
                cmCommand.Parameters.Clear();
                cmCommand.Parameters.AddWithValue("@staffid", this.StaffID);
                cmCommand.Parameters.AddWithValue("@adminuserid", loggedUserId); 
                cmCommand.CommandText = "sp_delete_staff";
                cmCommand.CommandType = CommandType.StoredProcedure;
                myConHelper.Open();
                cmCommand.ExecuteNonQuery();
                myConHelper.Close();
                UserActivity.RecordActivity("Deleted staff and user account");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
