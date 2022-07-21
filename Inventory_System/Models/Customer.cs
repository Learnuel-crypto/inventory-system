using System;
using System.Data;
using System.Data.SqlClient;
using Inventory_System.Model;
using Inventory_System.Model.Helper;

namespace Inventory_System.Models
{
    public class Customer
    {
        private string cusid;
        private DataTable _table;
        private SqlDataAdapter da;
        public string CusID
        {
            get { return cusid; }
            set { cusid = value; }

        }

        private string name;

        /// <summary>
        /// customer name
        /// </summary>
        internal string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("customer name cannot be empty");
                Validation.Name(value);
                name = value;
            }
        }

        private string contact;

        internal string Contact
        {
            get { return contact; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Contact cannot be empty");
                Validation.Contact(value,11,11);
                contact = value;
            }
        }

        private string address;

        /// <summary>
        /// customer address
        /// </summary>
        internal string Address
        {
            get { return address; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = "No address";
                address = value;
            }
        }
        /// <summary>
        /// register a new customer
        /// </summary>
        internal void Add()
        {
            try
            { 
                ISqlHelper myConHelper = Factory.CreateSqlConHelper();
                SqlCommand cmCommand = myConHelper.GetConnection().CreateCommand();
                cmCommand.Parameters.Clear();
                cmCommand.Parameters.AddWithValue("@name", this.Name);
                cmCommand.Parameters.AddWithValue("@contact", this.Contact);
                cmCommand.Parameters.AddWithValue("@address", this.Address); 
                cmCommand.CommandText = "sp_add_custeomer";
                cmCommand.CommandType = CommandType.StoredProcedure;
                myConHelper.Open();
                cmCommand.ExecuteNonQuery();
                myConHelper.Close();
                UserActivity.RecordActivity(String.Format("Registered a customer: {0}",Name));
                 
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Update customer details
        /// </summary>
        internal void Update()
        {
            try
            {

                ISqlHelper myConHelper = Factory.CreateSqlConHelper();
                SqlCommand cmCommand = myConHelper.GetConnection().CreateCommand();
                cmCommand.Parameters.Clear();
                cmCommand.Parameters.AddWithValue("@cusid", this.CusID);
                cmCommand.Parameters.AddWithValue("@name", this.Name);
                cmCommand.Parameters.AddWithValue("@contact", this.Contact);
                cmCommand.Parameters.AddWithValue("@address", this.Address);
                cmCommand.CommandText = "sp_update_cutomer";
                cmCommand.CommandType = CommandType.StoredProcedure;
                myConHelper.Open();
                cmCommand.ExecuteNonQuery();
                myConHelper.Close();
                UserActivity.RecordActivity(String.Format("Updated a customer detail: {0}:{1}", CusID,Name));
                 
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Delete a customer
        /// </summary>
        internal void Delete()
        {
            try
            {

                ISqlHelper myConHelper = Factory.CreateSqlConHelper();
                SqlCommand cmCommand = myConHelper.GetConnection().CreateCommand();
                cmCommand.Parameters.Clear();
                cmCommand.Parameters.AddWithValue("@cusid", this.CusID); 
                cmCommand.CommandText = "sp_delete_customer";
                cmCommand.CommandType = CommandType.StoredProcedure;
                myConHelper.Open();
                cmCommand.ExecuteNonQuery();
                myConHelper.Close();
                UserActivity.RecordActivity(String.Format("delete a customer : {0}", Name));
                 
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        internal DataTable Display(string search)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_search_customer";
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
        /// Display only name of customers
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        internal DataTable DisplayNames(string search)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_search_customer_names";
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
        /// Get customer credits
        /// </summary>
        /// <param name="cusid"></param>
        /// <returns></returns>
        internal DataTable CustomerCredits(string cusid)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@cusid", cusid);
                myComand.CommandText = "sp_search_customer";
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
    }
}
