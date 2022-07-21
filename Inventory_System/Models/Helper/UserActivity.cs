using System;
using System.Data;
using System.Data.SqlClient;

namespace Inventory_System.Model.Helper
{
  public  class UserActivity:Users
    {
        /// <summary>
        /// Methods are not connect to the table
        /// </summary>
        /// <param name="description"></param>
        public string Description { get; set; }
        private DataTable _table;
        public UserActivity(string description)
        {
            RecordActivity(description);
        }

        public UserActivity()
        {
        }
        /// <summary>
        /// Record use acctivity
        /// </summary>
        /// <param name="description"></param>
        public static void RecordActivity(string description)
        {
            try
            {
                ISqlHelper connection = Factory.CreateSqlConHelper();

                SqlCommand myComand = connection.GetConnection().CreateCommand();
                myComand.Parameters.Clear();
                myComand.Parameters.AddWithValue("@userid", Users.LoggedUserID);
                myComand.Parameters.AddWithValue("@description", description);
                myComand.Parameters.AddWithValue("@date", ToDateTime());
                myComand.CommandText = "sp_activity";
                myComand.CommandType = CommandType.StoredProcedure;
                connection.Open();
                myComand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Record user activity
        /// </summary>
        public void RecordActivity()
        {
            try
            {
                ISqlHelper connection = Factory.CreateSqlConHelper();

                SqlCommand myComand = connection.GetConnection().CreateCommand();
                myComand.Parameters.Clear();
                myComand.Parameters.AddWithValue("@userid", Users.LoggedUserID);
                myComand.Parameters.AddWithValue("@description", this.Description);
                myComand.Parameters.AddWithValue("@description", ToDateTime());
                myComand.CommandText = "sp_activity";
                myComand.CommandType = CommandType.StoredProcedure;
                connection.Open();
                myComand.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Search by date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public DataTable SearchByDate(DateTime date)
        {
            try
            {
                ISqlHelper connection = Factory.CreateSqlConHelper(); 
                SqlCommand cmd = new SqlCommand("sp_user_logs_by_date", connection.GetConnection());
                cmd.Parameters.AddWithValue("@datefrom", date); 
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                _table = new DataTable();
                da.Fill(_table);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                return _table;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        /// <summary>
        /// Display all user logs
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public DataTable DisplayUserLog(string search )
        {
            try
            {
                ISqlHelper connection = Factory.CreateSqlConHelper();
                SqlCommand cmd = new SqlCommand("sp_user_logs", connection.GetConnection());
                cmd.Parameters.AddWithValue("@search", search); 
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                _table = new DataTable();
                da.Fill(_table);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                return _table;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
         
        /// <summary>
        /// Date and Time format
        /// </summary>
        /// <returns></returns>
        public static string ToDateTime()
        {
            return DateTime.Now.ToString("MM/dd/yyyy ") + string.Format("{0:hh:mm:ss tt}", DateTime.Now);
        }
        
        /// <summary>
        /// Search between dates
        /// </summary>
        /// <param name="datefrom"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public DataTable SearchBetweenDates(DateTime datefrom, DateTime to )
        {
            try
            {
                ISqlHelper connection = Factory.CreateSqlConHelper();
                SqlCommand cmd = new SqlCommand("sp_user_logs_between_date", connection.GetConnection());
                cmd.Parameters.AddWithValue("@datefrom", datefrom);
                cmd.Parameters.AddWithValue("@dateto", to); 
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                _table = new DataTable();
                da.Fill(_table);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                return _table;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
