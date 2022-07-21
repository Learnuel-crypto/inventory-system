using Inventory_System.Model;
using Inventory_System.Model.Helper;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Inventory_System.Models
{
    public class Products:Category
    {
        #region PROPERTIES

        protected internal Random rand;
        private string id;
        protected internal string ProID
        {
            get { return id; }
            set { id = value; }
        }
        private string desc;
        protected internal string Description
        {
            get { return desc; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Product name can't be empty");
                desc = value;
            }
        }
        private int qty;
        protected internal int Quantity
        {
            get { return qty; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new Exception("Quantity cannot be empty");
                if (value < 0)
                    throw new Exception("Quanity cannot be negative");
                qty = value;
            }
        }
            private Decimal sellingPrice;
            protected internal Decimal SellingPrice
            {
                get{ return sellingPrice; }
                set{
                    if (string.IsNullOrEmpty(value.ToString()))
                        throw new Exception("Selling price cannot be empty");
                     Validation.Amount(value.ToString());
                    if (value <= 0m)
                        throw new Exception("Selling price can't be zoer(0) or negative");

                    sellingPrice = value;
                }
            }
            private int packing;
            /// <summary>
            /// total quantity per carton
            /// </summary>
        protected internal int Packing
        {
            get { return packing; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new Exception("Packing value cannot be empty");
                if (value <= 0)
                    throw new Exception("Packing can't be negative or zero(0)");
                packing = value;
            }
        }
            private Decimal itemDiscount;
            
        /// <summary>
        /// Discount for each item
        /// </summary>
            protected internal Decimal ItemDiscount
            {
                get { return itemDiscount; }
                set
                {
                    if (string.IsNullOrEmpty(value.ToString()))
                        value = 0.00m;
                    itemDiscount = value;
                }
            }
        private Decimal total;
        /// <summary>
        /// total cost of item
        /// </summary>
        public Decimal Total
        {
            get { return total; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new Exception("Item total amount to pay cannot be empty");
                Validation.Amount(value.ToString());
                if (value < 0m)
                    throw new Exception("item total amount cannot be negative ");
                total = value;
            }
        }
        #endregion

        #region METHODS
        protected internal sealed override void Add()
        {

           try  
            { 
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@brandname", BrendName);
                myComand.Parameters.AddWithValue("@description ", Description);
                myComand.Parameters.AddWithValue("@quantity ", Quantity);
                myComand.Parameters.AddWithValue("@price ", SellingPrice);
                myComand.Parameters.AddWithValue("@packing ", Packing);
                myComand.CommandText = "sp_add_product";
                myComand.CommandType = CommandType.StoredProcedure;
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                UserActivity.RecordActivity(string.Format("Added {0} units of {1} ", Quantity, Description));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        protected internal sealed override void Update()
        {
           try {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@proid", ProID);
                myComand.Parameters.AddWithValue("@brandname", BrendName);
                myComand.Parameters.AddWithValue("@description ", Description);
                myComand.Parameters.AddWithValue("@quantity ", Quantity);
                myComand.Parameters.AddWithValue("@price ", SellingPrice);
                myComand.Parameters.AddWithValue("@packing ", Packing);
                myComand.CommandText = "sp_update_product";
                myComand.CommandType = CommandType.StoredProcedure;
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
               UserActivity.RecordActivity(string.Format("Updated product {0}", Description));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        protected internal sealed override void Delete()
        {
            try{
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@proid", ProID);
                myComand.CommandText = "sp_delete_product";
                myComand.CommandType = CommandType.StoredProcedure;
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                UserActivity.RecordActivity(string.Format("Delete product {0}", Description));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        protected internal override DataTable Display(string search)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_display_products";
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
        protected internal virtual DataTable Display(string search,string brandname)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.Parameters.AddWithValue("@brand", brandname);
                myComand.CommandText = "sp_display_products_by_brand";
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
        private string GenerateID(string description)
        {
            int randValue = rand.Next();
            var proKey = description.Substring(0, 2).ToUpper().Trim() + randValue.ToString().Substring(0, 3);
            //query database to see if key exist
            ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
            using (SqlConnection myconn = mySqlHelper.GetConnection())
            {
                myconn.Open();
                SqlCommand cmd = new SqlCommand("sp_check_id_exist", myconn);
                cmd.Parameters.AddWithValue("proid", proKey);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(sdr);

                if (table.Rows.Count > 0)
                {
                    return GenerateID(description);
                }

                return proKey;

            }

        }

        /// <summary>
        /// Search stock by date
        /// </summary>
        /// <param name="from"></param>
        /// <returns></returns>
        protected internal virtual  DataTable DisplayByDate(DateTime from)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@datefrom", from);
                myComand.CommandText = "sp_display_products_by_date";
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
        /// Search stock between dates
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        protected internal virtual DataTable DisplayBetweenDate(DateTime from,DateTime to)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@datefrom", from);
                myComand.Parameters.AddWithValue("@dateto", to);
                myComand.CommandText = "sp_display_products_between_date";
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
        /// Display products y brand
        /// </summary>
        /// <param name="brand">name of the brand</param>
        /// <returns></returns>
        protected internal virtual DataTable DisplayByBrand(string brand)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@brand", brand);
                myComand.CommandText = "sp_get_product_by_brand";
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


    }
}
