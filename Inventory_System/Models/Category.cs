using Inventory_System.Model;
using Inventory_System.Model.Helper;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Inventory_System.Models
{
    public class Category
    {
        public DataTable _table;
        public SqlDataAdapter da;
        public SqlCommand myComand;
        private string brendID;
        /// <summary>
        /// Brand or category ID
        /// </summary>
        protected internal string BrendID
        {
            get { return brendID; }
            set { brendID = value; }
        }

        private string brend;
        /// <summary>
        /// Brand or category name
        /// </summary>
        internal string BrendName
        {
            get { return brend; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Brend name cannot be empty");
                brend = value;
            }

        }

        protected internal virtual void Add()
        { 
            try{

                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@brandname", BrendName); 
                myComand.CommandText = "sp_add_brand";
                myComand.CommandType = CommandType.StoredProcedure;
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                UserActivity.RecordActivity(string.Format("Added new brand {0}  ", BrendName));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        protected internal virtual void Update()
        {
            try
            {

                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@brandname", BrendName);
                myComand.Parameters.AddWithValue("@brandid", BrendID);
                myComand.CommandText = "sp_update_brand";
                myComand.CommandType = CommandType.StoredProcedure;
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                UserActivity.RecordActivity(string.Format("Updated brand {0}  ", BrendName));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        protected internal virtual void Delete()
        {
            try
            {

                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@brandid", BrendID);
                myComand.CommandText = "sp_delete_brand";
                myComand.CommandType = CommandType.StoredProcedure;
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                UserActivity.RecordActivity(string.Format("Deleted brand {0}  ", BrendName));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        protected internal virtual DataTable Display(string search)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_get_category";
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
        /// Get category by product
        /// </summary>
        /// <param name="proid"></param>
        /// <returns></returns>
        protected internal string GetCategoryByProduct(string proid)
        {
            try
            {
                string category = "none";
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@proid", proid);
                myComand.CommandText = "sp_get_category_by_proid";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();

                if (_table.Rows.Count > 0)
                {
                    foreach (DataRow row in _table.Rows)
                    {
                        category = row["BrandName"].ToString();
                    }
                }

                return category;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
