
using Inventory_System.Model.Helper;
using Inventory_System.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory_System.Model
{
    /// <summary>
    /// Prints throught the DGVPrinterHelper class
    /// </summary>
    public class MyPrinter
    { 
        public MyPrinter()
        {

        } 
        public static bool Print = true;
         
        private static string companyName;
        /// <summary>
        /// The name of th company or business
        /// </summary>
        public static string CompanyName
        {
            get
            {
                if (string.IsNullOrEmpty(companyName))
                    return "Inventory system";
                return companyName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    companyName = "Inventory system";
                
                companyName = value;
            }
        }



        /// <summary>
        /// The address of the company
        /// </summary>
        private static string address;

        public static string Address
        {
            get
            {
                if (string.IsNullOrEmpty(address))
                    return "No address";
                return address;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Enter company address");
                address = value;
            }
        }
        private static string mail;
        /// <summary>
        /// Company emaill address
        /// </summary>
        public static string Email
        {
            get { return mail; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    Validation.Email(value);
                mail = value;
            }
        }

        private static  string contact;
        /// <summary>
        /// Company contact
        /// </summary>
        public static string Contact
        {
            get
            {
                if (string.IsNullOrEmpty(contact))
                    return "No contact";
                return    contact;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    Validation.Contact(value, 11, 15);
                contact = value;
            }
        }

       
        
        /// <summary>
        /// set page title for printing
        /// </summary>
        public static string printTitle { get; set; }
        /// <summary>
        /// Print in portrate formate A4 paper
        /// </summary>
        /// <param name="recordsDataGridView"></param>
        /// <param name="title"></param>
        public static void PrintRecordsPortrate(DataGridView recordsDataGridView, string title)
        {
            try
            {

                DGVPrinter printer = new DGVPrinter();
                printer.Title = CompanyName.ToUpper();//the page heading
                printer.SubTitle = title.ToUpper();
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PageNumberAlignment = StringAlignment.Near;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.FooterSpacing = 15;
                printer.PrintDialogSettings.AllowPrintToFile = true;
                printer.ShowTotalPageNumber = true;
                printer.PrintDataGridView(recordsDataGridView);
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// print record using landscape formate
        /// </summary>
        /// <param name="recordsDataGridView"></param>
        /// <param name="title"></param>
        public static void PrintRecords(DataGridView recordsDataGridView, string title)
        {
            try
            {
                DGVPrinter printer = new DGVPrinter();
                recordsDataGridView.AutoSize = true;
                printer.Title = CompanyName.ToUpper();//the page heading
                printer.SubTitle = title.ToUpper();
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.FooterSpacing = 15;
                printer.PrintDialogSettings.AllowPrintToFile = true;
                printer.ShowTotalPageNumber = true;
                printer.printDocument.DefaultPageSettings.Landscape = true;
                printer.PrintDataGridView(recordsDataGridView);
            }
            catch (Exception)
            {

            }
        }
        public static void GetReceiptDetails()
        {
            try
            {

                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection myconn = mySqlHelper.GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_receipt_details", myconn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        DataRow row = table.Rows[0];
                        companyName = row["Name"].ToString();
                        address = row["Address"].ToString();
                        contact = row["Contact"].ToString();

                    }

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Set the receipt detailss
        /// </summary>
        public static void SetReceiptDetails()
        {
            try
            { 
                ISqlHelper myConHelper = Factory.CreateSqlConHelper();
                SqlCommand cmCommand = myConHelper.GetConnection().CreateCommand();
                cmCommand.Parameters.Clear();
                cmCommand.Parameters.AddWithValue("@name", CompanyName.ToUpper());
                cmCommand.Parameters.AddWithValue("@contact", Contact);
                cmCommand.Parameters.AddWithValue("@address", Address);
                cmCommand.CommandText = "sp_set_receipt";
                cmCommand.CommandType = CommandType.StoredProcedure;
                myConHelper.Open();
                cmCommand.ExecuteNonQuery();
                myConHelper.Close();
                UserActivity.RecordActivity("Set Receipt details"); 
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
