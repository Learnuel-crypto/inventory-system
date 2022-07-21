using System;
using System.Collections.Generic;
using Inventory_System.Model;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Inventory_System.Model.Helper;
using Validation = Inventory_System.Model.Validation;

namespace Inventory_System.Models
{
    public class Sales : Products
    {
        protected internal Decimal TodayTotalSale { get; private set; }
        protected internal Decimal CashTotalSale { get; private set; }
        private string saleid;

        protected internal string SalesID
        {
            get { return saleid; }
            set { saleid = value; }
        }

        protected internal Customer customer { get; set; }

        private string billid;

        protected internal string BillID
        {
            get { return billid; }
            set { billid = value; }
        }

        private Decimal amount;
        /// <summary>
        /// total Cost of items
        /// </summary>
        protected internal Decimal TotalAmount
        {
            get { return amount; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new Exception("Total amount cannot be empty");
                Validation.Amount(value.ToString());
                if (value < 0m)
                    throw new Exception("Total amount cannot be negative ");
                amount = value;
            }
        }

        private int totalQuantity;
        /// <summary>
        /// Total Quantity of items
        /// </summary>
        protected internal int TotalQuantity
        {
            get { return totalQuantity; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new Exception("Total quantity cannot be empty");
                if (value < 0m)
                    throw new Exception("Total quantity cannot be negative ");
                totalQuantity = value;
            }
        }

        private string status;

        protected internal string Status
        {
            get { return status; }
            set
            {
                if (value.ToLower() != "sold"  && value.ToLower() != "returned")
                    throw new Exception("Invalid sell status (e.g sold or returned)");
                status = value;
            }

        }

        private Decimal discount;

        protected internal Decimal Discount
        {
            get { return discount; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                        value = 0.00m;
                discount = value;
            }
        }
        private Decimal paidAmount;
        /// <summary>
        /// Amount to pay
        /// </summary>
        public Decimal PaidAmount
        {
            get { return paidAmount; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new Exception("Amount to pay cannot be empty");
                Validation.Amount(value.ToString());
                if (value < 0m)
                    throw new Exception("Paid amount cannot be negative ");
                paidAmount = value;
            }
        }
        private Decimal balance;

        public Decimal Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                    throw new Exception("Balance amount cannot be negative");
                balance = value;
            }
        }

        private Decimal grandTotal;
        /// <summary>
        /// Netpay
        /// </summary>
        protected internal Decimal GrandTotal
        {
            get { return grandTotal; }
            set
            {
                value = TotalAmount - (TotalAmount * Discount / 100.00m);
                grandTotal = value;
            }
           
        }

        private string salesType;

        protected internal string SalesType
        {
            get { return salesType; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Sales type cannot be empty");
                if (value != "Cash" && value != "Cheque")
                    throw new Exception("Invalid sales type entered (Cash or Cheque)");
                salesType = value;
            }
        }

        protected internal Cheque CustomerCheque { get; set; }
        private DateTime date;
        /// <summary>
        /// Date of sale
        /// </summary>
        protected internal DateTime Date { get; set; }
        /// <summary>
        /// Get the data and time sale was made
        /// </summary>
        /// <returns></returns>
        protected internal string ToDateTime(DateTime date )
        { 
             return date.ToString("MM/dd/yyyy ") + string.Format("{0:hh:mm:ss tt}", DateTime.Now);
        }
       /// <summary>
       /// Make cash sale
       /// </summary>
       /// <param name="cart"></param>
       internal void MakeSale(List<Products> cart)
        {
            ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();

            using (SqlConnection myconnection = mySqlHelper.GetConnection())
            {
                myconnection.Open();
                 
                SqlCommand salesComand = myconnection.CreateCommand();
                SqlCommand saleItemsComand = myconnection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = myconnection.BeginTransaction(
                    IsolationLevel.ReadCommitted, "SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction. 
                salesComand.Connection = myconnection;
                salesComand.Transaction = transaction;
                saleItemsComand.Connection = myconnection;
                saleItemsComand.Transaction = transaction;
                try
                {
                    
                    //insert into sales table
                   salesComand.Parameters.AddWithValue("@salesid", GenerateInvoiceID());
                    salesComand.Parameters.AddWithValue("@billno", BillID); 
                    salesComand.Parameters.AddWithValue("@totalamount", TotalAmount ); 
                    salesComand.Parameters.AddWithValue("@date",  ToDateTime(DateTime.Now)); 
                    salesComand.Parameters.AddWithValue("@totalqty", TotalQuantity ); 
                    salesComand.Parameters.AddWithValue("@saletype", SalesType ); 
                    salesComand.Parameters.AddWithValue("@status", Status ); 
                    salesComand.Parameters.AddWithValue("@discount",Discount  );
                    salesComand.Parameters.AddWithValue("@amount", PaidAmount);
                    salesComand.Parameters.AddWithValue("@balance",Balance  ); 
                    salesComand.Parameters.AddWithValue("@grandtotal",GrandTotal  ); 
                    salesComand.Parameters.AddWithValue("@userid", Users.LoggedUserID );
                    salesComand.CommandText = "sp_make_cash_sale";
                    salesComand.CommandType = CommandType.StoredProcedure;
                    salesComand.ExecuteNonQuery();

                    foreach (Products item in cart)
                    {
                        //insert each product contained in the sales into the items table
                        saleItemsComand.Parameters.Clear();
                        saleItemsComand.Parameters.AddWithValue("@proid", item.ProID);
                        saleItemsComand.Parameters.AddWithValue("@Quantity", item.Quantity);
                        saleItemsComand.Parameters.AddWithValue("@price", item.SellingPrice); 
                        saleItemsComand.Parameters.AddWithValue("@discount", item.ItemDiscount);
                        saleItemsComand.Parameters.AddWithValue("@total", item.Total);
                        saleItemsComand.Parameters.AddWithValue("@salesid", SalesID);
                        saleItemsComand.CommandText = "sp_sales_items";
                        saleItemsComand.CommandType = CommandType.StoredProcedure;
                        saleItemsComand.ExecuteNonQuery();
                    }
                    UserActivity.RecordActivity(String.Format("Made a sale with invoice id {0}", SalesID));
                   
                    transaction.Commit();
                    TodayTotalSales();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    SalesID = null;
                    throw new Exception(ex.Message+"\nTransaction failed");
                }
            }
        }
        /// <summary>
        /// Make credit sale by cheque
        /// </summary>
        /// <param name="cart"></param>
        internal void MakeChequeSale(List<Products> cart)
        {
            ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();

            using (SqlConnection myconnection = mySqlHelper.GetConnection())
            {
                myconnection.Open();
                 
                SqlCommand salesComand = myconnection.CreateCommand();
                SqlCommand saleItemsComand = myconnection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = myconnection.BeginTransaction(
                    IsolationLevel.ReadCommitted, "SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction.

                salesComand.Connection = myconnection;
                salesComand.Transaction = transaction;
                saleItemsComand.Connection = myconnection;
                saleItemsComand.Transaction = transaction;
                try
                {

                    //insert into sales table
                    salesComand.Parameters.AddWithValue("@salesid", GenerateInvoiceID());
                    salesComand.Parameters.AddWithValue("@billno", BillID);
                    salesComand.Parameters.AddWithValue("@cusid", customer.CusID);
                    salesComand.Parameters.AddWithValue("@totalamount", TotalAmount);
                    salesComand.Parameters.AddWithValue("@date", ToDateTime(DateTime.Now));
                    salesComand.Parameters.AddWithValue("@totalqty", TotalQuantity);
                    salesComand.Parameters.AddWithValue("@saletype", SalesType);
                    salesComand.Parameters.AddWithValue("@status", Status);
                    salesComand.Parameters.AddWithValue("@discount", Discount);
                    salesComand.Parameters.AddWithValue("@amount", PaidAmount);
                    salesComand.Parameters.AddWithValue("@balance", Balance);
                    salesComand.Parameters.AddWithValue("@grandtotal", GrandTotal);
                    salesComand.Parameters.AddWithValue("@chequedate", CustomerCheque.ChequeDate);
                    salesComand.Parameters.AddWithValue("@userid", Users.LoggedUserID);
                    salesComand.CommandText = "sp_make_cheque_sale";
                    salesComand.CommandType = CommandType.StoredProcedure;
                    salesComand.ExecuteNonQuery();

                    foreach (Products item in cart)
                    {
                        //insert each product contained in the sales into the items table
                        saleItemsComand.Parameters.Clear();
                        saleItemsComand.Parameters.AddWithValue("@proid", item.ProID);
                        saleItemsComand.Parameters.AddWithValue("@Quantity", item.Quantity);
                        saleItemsComand.Parameters.AddWithValue("@price", item.SellingPrice);
                        saleItemsComand.Parameters.AddWithValue("@discount", item.ItemDiscount);
                        saleItemsComand.Parameters.AddWithValue("@total", item.Total);
                        saleItemsComand.Parameters.AddWithValue("@salesid", SalesID);
                        saleItemsComand.CommandText = "sp_sales_items";
                        saleItemsComand.CommandType = CommandType.StoredProcedure;
                        saleItemsComand.ExecuteNonQuery();
                    }
                    UserActivity.RecordActivity(String.Format("Made a cheque sale with invoice id {0}", SalesID));
                    
                    transaction.Commit();
                    TodayTotalSales();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    SalesID = null;
                    throw new Exception(ex.Message + "\nTransaction failed");
                }
            }
        }
        

        protected internal override DataTable Display(string search)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_search_sales";
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

        protected internal override  DataTable DisplayByDate(DateTime from)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@datefrom", from);
                myComand.CommandText = "sp_today_sales";
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

        protected internal override DataTable DisplayBetweenDate(DateTime from, DateTime to)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@datefrom", from);
                myComand.Parameters.AddWithValue("@dateto", to);
                myComand.CommandText = "sp_sales_between_dates";
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
        /// Bill id exist
        /// </summary>
        /// <param name="billno"></param>
        /// <returns></returns>
        protected internal bool BillNoExist(string billno)
        {
            ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
            using (SqlConnection myconn = mySqlHelper.GetConnection())
            {
                myconn.Open();
                SqlCommand cmd = new SqlCommand("sp_bill_already_exist", myconn);
                cmd.Parameters.AddWithValue("@billno", billno);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(sdr);

                if (table.Rows.Count > 0)
                {

                    return true;

                }

                return false;
            }
        }
        /// <summary>
        /// Check existing sales id
        /// </summary>
        /// <param name="saleid"></param>
        /// <returns></returns>
        protected internal string BillInvoiceExist(string saleid)
        {
            ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
            using (SqlConnection myconn = mySqlHelper.GetConnection())
            {
                myconn.Open();
                SqlCommand cmd = new SqlCommand("sp_saleid_already_exist", myconn);
                cmd.Parameters.AddWithValue("@saleid", saleid);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(sdr);

                if (table.Rows.Count > 0)
                {

                    return SalesID=GenerateInvoiceID();

                }

                return SalesID;
            }
        }
        /// <summary>
        /// Get the last bill id
        /// </summary>
        /// <returns></returns>
        private string GetLastBillID()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection myconn = mySqlHelper.GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_last_billid", myconn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        DataRow row = table.Rows[0];
                        return row["BillNo"].ToString();

                    }

                    return "Bil000";

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Generate bill number
        /// </summary>
        /// <returns></returns>
        protected   internal string GenerateBillNo()
        {
            try
            {
                rand=new Random(); 
                var lastkey = GetLastBillID();
                if (lastkey != null)
                {
                    var firsHalf = lastkey.Substring(0, 3);
                    var middel = lastkey.Substring(3,1);
                    string secondHalf = (Convert.ToInt32(middel) + 1).ToString();
                    string ending = rand.Next().ToString().Substring(0, 4);

                    lastkey = firsHalf + secondHalf + ending;
                }

                return BillID = lastkey;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Generate sale or invoice id
        /// </summary>
        /// <returns></returns>
          private string GenerateInvoiceID()
        {
            try
            {
                rand = new Random();
                var lastkey = GetLastSaleID();
                if (lastkey != null)
                {
                    var firsHalf = lastkey.Substring(0, 3);
                    var middel = lastkey.Substring(3,1);
                    string secondHalf = (Convert.ToInt32(middel) + 1).ToString();
                    string ending = rand.Next().ToString().Substring(0, 4);

                    lastkey = firsHalf + secondHalf+ ending;
                }
                SalesID = lastkey;
                return BillInvoiceExist(SalesID);
                   
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private string GetLastSaleID()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection myconn = mySqlHelper.GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_last_sales_id", myconn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        DataRow row = table.Rows[0];
                        return row["SalesID"].ToString();

                    }

                    return "Inv000";

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        #region sales items search and sales
        /// <summary>
        /// Displays all items sold
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        protected internal DataTable DisplaySalesItems(string search)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_display_items";
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
        protected internal DataTable DisplayItemsBySaleID(string saleid)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@saleid", saleid);
                myComand.CommandText = "sp_display_items_by_salesid";
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
        /// Display returned items
        /// </summary>
        /// <param name="saleid"></param>
        /// <returns></returns>
        protected internal DataTable DisplayItemsReturned(string saleid)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@saleid", saleid);
                myComand.CommandText = "sp_display_returned_items_by_salesid";
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
        /// Display all items returned
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        protected internal DataTable SearchItemsReturned(string search)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_display_returned_items";
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
        /// Search returned items by date
        /// </summary>
        /// <param name="from"></param>
        /// <returns></returns>
        protected internal DataTable SearchItemsReturnedByDate(DateTime from)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@datefrom", from);
                myComand.CommandText = "sp_returned_items_by_date";
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
        /// Seach all returned items between dates
        /// </summary>
        /// <param name="from"></param>
        /// <param name="dateto"></param>
        /// <returns></returns>
        protected internal DataTable SearchItemsReturnedBetweenDate(DateTime from,DateTime dateto)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@datefrom", from);
                myComand.Parameters.AddWithValue("@dateto", dateto);
                myComand.CommandText = "sp_returned_items_between_date";
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
        #endregion
        #region find and return sales
        /// <summary>
        /// Find sale by invoice or bill number
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        protected internal string FindSale(string search)
        {
            try
            {
                string foundID = null;
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection myconn = mySqlHelper.GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_find_sales", myconn);
                    cmd.Parameters.AddWithValue("@search", search);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        DataRow row = table.Rows[0];
                        foundID =  row["SalesID"].ToString();

                    }

                    return foundID;

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Return sold stock (multiple items at a go)
        /// </summary>
        /// <param name="items"></param>
        internal void ReturnSale(DataGridView items)
        {
            ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();

            using (SqlConnection myconnection = mySqlHelper.GetConnection())
            {
                myconnection.Open();

                SqlCommand salesComand = myconnection.CreateCommand();
                SqlCommand saleItemsComand = myconnection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = myconnection.BeginTransaction(
                    IsolationLevel.ReadCommitted, "SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction. 
                salesComand.Connection = myconnection;
                salesComand.Transaction = transaction;
                saleItemsComand.Connection = myconnection;
                saleItemsComand.Transaction = transaction;
                try
                {

                    //insert into sales table
                    salesComand.Parameters.AddWithValue("@saleid", SalesID); 
                    salesComand.Parameters.AddWithValue("@status", Status); 
                    salesComand.CommandText = "sp_update_sale";
                    salesComand.CommandType = CommandType.StoredProcedure;
                    salesComand.ExecuteNonQuery();

                    foreach (DataGridViewRow item in items.Rows)
                    {
                        //insert each product contained in the sales into the items table
                        saleItemsComand.Parameters.Clear();
                        saleItemsComand.Parameters.AddWithValue("@id", item.Cells[0].Value);
                        saleItemsComand.Parameters.AddWithValue("@qty", item.Cells[3].Value);
                        saleItemsComand.Parameters.AddWithValue("@total", item.Cells[6].Value);
                        saleItemsComand.CommandText = "sp_return_product";
                        saleItemsComand.CommandType = CommandType.StoredProcedure;
                        saleItemsComand.ExecuteNonQuery();
                    }
                    UserActivity.RecordActivity(String.Format("Returned a sale with invoice id {0}", SalesID));
                    transaction.Commit();
                    
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); 
                    throw new Exception(ex.Message + "\nTransaction failed");
                }
            }
        }
        /// <summary>
        /// Return individual items 
        /// </summary>
        /// <param name="items"></param>
        internal void ReturnSale(Sales item)
        {
            ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();

            using (SqlConnection myconnection = mySqlHelper.GetConnection())
            {
                myconnection.Open(); 
                SqlCommand salesComand = myconnection.CreateCommand();
                SqlCommand saleItemsComand = myconnection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = myconnection.BeginTransaction(
                    IsolationLevel.ReadCommitted, "SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction. 
                salesComand.Connection = myconnection;
                salesComand.Transaction = transaction;
                saleItemsComand.Connection = myconnection;
                saleItemsComand.Transaction = transaction;
                try
                { 
                    //insert into sales table
                    salesComand.Parameters.AddWithValue("@saleid", item.SalesID);
                    salesComand.Parameters.AddWithValue("@status", item.Status);
                    salesComand.Parameters.AddWithValue("@amount", item.TotalAmount);
                    salesComand.Parameters.AddWithValue("@quantity", item.Quantity);
                    salesComand.CommandText = "sp_update_sale_by_solditems";
                    salesComand.CommandType = CommandType.StoredProcedure;
                    salesComand.ExecuteNonQuery();
                         //insert each product contained in the sales into the items table
                        saleItemsComand.Parameters.Clear();
                        saleItemsComand.Parameters.AddWithValue("@id", item.BrendID);
                        saleItemsComand.Parameters.AddWithValue("@qty", item.Quantity);
                        saleItemsComand.Parameters.AddWithValue("@total", item.TotalAmount);
                        saleItemsComand.CommandText = "sp_return_product";
                        saleItemsComand.CommandType = CommandType.StoredProcedure;
                        saleItemsComand.ExecuteNonQuery();
                        var x = item.Quantity > 1 ? "s" : " ";
                    UserActivity.RecordActivity(String.Format("Returned {0} prouduct{1} from sale with invoice id {2}",item.Quantity,x, SalesID));
                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception(ex.Message + "\nTransaction failed");
                }
            }
        }
        /// <summary>
        /// Display returned sales
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        protected internal DataTable DisplayReturnedSales(string search)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_returned_sales";
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
        /// Display cheque sales
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        protected internal DataTable DisplayChequeSales(string search)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_cheque_sales";
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
        #endregion

        #region  Daily sales total
        /// <summary>
        /// Set today total sales values
        /// </summary>
        internal void TodayTotalSales()
        {
            try
            {  
                ISqlHelper sqlCon = Factory.CreateSqlConHelper();
                SqlConnection con = sqlCon.GetConnection();
                SqlCommand cmCommand = new SqlCommand("sp_today_total_sales", con);
                cmCommand.Parameters.Clear(); 
                cmCommand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmCommand);
                 _table = new DataTable();
                con.Open();
                da.Fill(_table);
                cmCommand.ExecuteNonQuery();
                TodayTotalSale = 0.00m;
                CashTotalSale = 0.00m;
                if (_table.Rows.Count > 0)
                {
                    DataRow myrow = _table.Rows[0];

                    foreach (DataRow row in _table.Rows)
                    {
                        if (!string.IsNullOrEmpty(row["Total"].ToString()))
                        {
                            TodayTotalSale = Convert.ToDecimal(row["Total"].ToString());
                            CashTotalSale = Convert.ToDecimal(row["Paid"].ToString());
                        }
                    }
                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        #endregion
    }
}
