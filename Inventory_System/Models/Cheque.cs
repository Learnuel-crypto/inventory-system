using System;
using Inventory_System.Model;
using System.Data;
using System.Data.SqlClient;
using Inventory_System.Model.Helper;

namespace Inventory_System.Models
{
    public  class Cheque:Customer
    {
        private SqlDataAdapter da;
        private DataTable _table;
        private string chequeID;
        public static Decimal Paid;
        public static Decimal CostAmount;
        public static Decimal ChequeBalance;
        protected internal string ChequeID
        {
            get { return chequeID; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Cheque number cannot be empty");
                chequeID = value;
            }
        }
        private Decimal amount;
        protected internal Decimal Amount
        {
            get { return amount; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new Exception("Cheque amount cannot be empty");
                Validation.Amount(value.ToString());
                if (value <= 0m)
                    throw new Exception("Cheque amount can't be zoer(0) or negative");
                amount = value;
            }
        }
        private Decimal balance;
        protected internal Decimal Balance
        {
            get { return amount; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new Exception("Balance amount cannot be empty");
                Validation.Amount(value.ToString());
                if (value < 0m)
                    throw new Exception("Balance amount can't be negative");
                balance = value;
            }
        }

        protected internal DateTime ChequeDate { get; set; }

        protected internal virtual DataTable DisplayBySaleID(string saleid)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@saleid", saleid);
                myComand.CommandText = "sp_display_customer_by_saleid";
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

        internal void GetPayments(string cusid)
        {
            try
            {

                  _table = new DataTable();
                SqlDataAdapter _adapter = new SqlDataAdapter();
                ISqlHelper sqlCon = Factory.CreateSqlConHelper();
                SqlConnection con = sqlCon.GetConnection();
                SqlCommand cmCommand = new SqlCommand("sp_get_total_credit", con);
                cmCommand.Parameters.Clear();
                cmCommand.Parameters.AddWithValue("@cusid", cusid);
                cmCommand.CommandType = CommandType.StoredProcedure;
                _adapter = new SqlDataAdapter(cmCommand);
                con.Open();
                _adapter.Fill(_table);
                cmCommand.ExecuteNonQuery();
                if (_table.Rows.Count > 0)
                {
                    foreach (DataRow row in _table.Rows)
                    {
                        if (string.IsNullOrEmpty(row["Amount"].ToString()))
                                 break;
                        CostAmount = Convert.ToDecimal(row["Amount"].ToString());
                        Paid = Convert.ToDecimal(row["Paid"].ToString());
                        ChequeBalance = Convert.ToDecimal(row["Balance"].ToString());

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// GEt all customer cheques sales
        /// </summary>
        /// <param name="cusid"></param>
        /// <returns></returns>
        protected internal virtual DataTable DisplayCredit(string cusid)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@cusid", cusid);
                myComand.CommandText = "sp_get_all_customer_credit";
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
        /// Make payment for cheque recieved
        /// </summary>
        /// <param name="saleid"></param>
        protected internal void PayCheque(string saleid)
        {
            ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();

            using (SqlConnection myconnection = mySqlHelper.GetConnection())
            {
                myconnection.Open();

                SqlCommand salesComand = myconnection.CreateCommand(); 
                SqlTransaction transaction; 


                transaction = myconnection.BeginTransaction(
                    IsolationLevel.ReadCommitted, "SampleTransaction");
                  
                salesComand.Connection = myconnection;
                salesComand.Transaction = transaction; 
                try
                { 
                    salesComand.Parameters.AddWithValue("@saleid", saleid);   
                    salesComand.Parameters.AddWithValue("@amount", Amount);  
                    salesComand.CommandText = "sp_pay_cheque";
                    salesComand.CommandType = CommandType.StoredProcedure;
                    salesComand.ExecuteNonQuery(); 
                    UserActivity.RecordActivity(String.Format("Paid a Cheque sale with invoice id {0}", saleid));
                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback(); 
                    throw new Exception(ex.Message + "\nTransaction failed");
                }
            }
        }
    }
}
