
using Inventory_System.Model;
using Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Inventory_System.API.Reports
{
    public partial class ReceiptFrm : Form
    {
        DataSet ds;
        DataTable Stock;
        public ReceiptFrm(List<Products> products,Sales sale)
        {
            InitializeComponent();
            SetReceiptData(products,sale);
        }

        private void SetReceiptData(List<Products> items,Sales Details)
        {
            try
            {
                int sn = 1;
                Stock = new DataTable();
                ds = new DataSet();
                if (items.Count > 0)
                {

                    Stock.Columns.AddRange(new DataColumn[7]
                    {
                        new DataColumn("S/n", typeof(int)),
                        new DataColumn("Brand", typeof(string)),
                        new DataColumn("Description", typeof(string)),
                        new DataColumn("Quantity", typeof(int)),
                        new DataColumn("Discount", typeof(Decimal)),
                        new DataColumn("Price", typeof(Decimal)), 
                        new DataColumn("Total", typeof(Decimal)), 
                    });
                    foreach (var item in items)
                    {
                        Stock.Rows.Add(sn,item.BrendName,item.Description,
                           item.Quantity, item.ItemDiscount,item.SellingPrice,item.Total);
                        sn++;
                    }
                }


                crpReceipt crp = new crpReceipt();
                crp.Database.Tables["Receipt"].SetDataSource(Stock);
                crpReceiptView.ReportSource = null;
                crp.SetParameterValue("BusinessName", MyPrinter.CompanyName = string.IsNullOrEmpty(MyPrinter.CompanyName) ? "Business Name" : MyPrinter.CompanyName); 
                crp.SetParameterValue("CusName",Details.customer.Name);
                crp.SetParameterValue("TotalCost",Details.TotalAmount);
                crp.SetParameterValue("InvoiceID",Details.SalesID);
                crp.SetParameterValue("BillNo",Details.BillID);
                crp.SetParameterValue("Discount",Details.Discount);
                crp.SetParameterValue("NetPay",Details.GrandTotal);
                crp.SetParameterValue("AmountPaid",Details.PaidAmount);
                crp.SetParameterValue("Balance",Details.Balance);
                crp.SetParameterValue("PaymentType",Details.SalesType); 
                crpReceiptView.ReportSource = crp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Receipt Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
