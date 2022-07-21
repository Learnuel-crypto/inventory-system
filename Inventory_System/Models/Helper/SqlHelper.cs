using System.ComponentModel.Design;
using System.Data.SqlClient;
using EncryptString;
using System.Configuration;

namespace Inventory_System.Model
{
    /// <summary>
    /// Handles the database connection logic
    /// </summary>
    public class SqlHelper : ISqlHelper
    {
        #region
        /// <summary>
        /// database connection class
        /// </summary>
        /// <returns>connection string</returns>
        StringEncryptor StrCrypt = new StringEncryptor();
        private SqlConnection cn;

        public SqlHelper()
        {
            
        }
        /// <summary>
        /// Connect to database
        /// </summary>
        /// <returns>connection string</returns>
        public SqlConnection GetConnection()
        {
            
            return cn= new SqlConnection(StrCrypt.Decrypt(ConfigurationManager.ConnectionStrings["DB"].ConnectionString));
        }
        #endregion


        public SqlHelper(string connectionString)
        {
            cn = new SqlConnection(connectionString);

        }
        /// <summary>
        /// Open connection if close
        /// </summary>
        public bool IsConnection
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();
                return true;
            }
        }

        /// <summary>
        /// Open connect if its close
        /// </summary>
        public void Open()
        {
            if (cn.State == System.Data.ConnectionState.Closed)
                cn.Open();
        }
        /// <summary>
        /// Close connection if open
        /// </summary>
        public void Close()
        { 
                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close(); 
        }
    }
}