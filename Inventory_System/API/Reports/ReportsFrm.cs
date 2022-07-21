using System;
using System.Data;
using System.Windows.Forms;
using Inventory_System.Models;
using Inventory_System.Model;

namespace Inventory_System.API.Reports
{
    public partial class ReportsFrm : Form
    {
        private Category category = Factory.CreateCategory();
        DataSet ds;
        DataTable Stock;
        public ReportsFrm(DataGridView dataset)
        {
            InitializeComponent();
            SetStockData(dataset);
        }

        public ReportsFrm()
        {
            InitializeComponent();
        }

        private void SetStockData(DataGridView data)
        {
            try
            {
                Stock = new DataTable();
                ds = new DataSet();
                if (data.RowCount > 0)
                {

                    Stock.Columns.AddRange(new DataColumn[6]
                    { 
                        new DataColumn("Description", typeof(string)),
                        new DataColumn("Quantity", typeof(int)),
                        new DataColumn("Price", typeof(Decimal)),
                        new DataColumn("Packing", typeof(int)),
                        new DataColumn("Brand", typeof(string)),
                        new DataColumn("Date_add", typeof(string)), 
                    });
                    foreach (DataGridViewRow dgv in data.Rows)
                    {
                        Stock.Rows.Add(dgv.Cells[1].Value, dgv.Cells[3].Value,
                            dgv.Cells[2].Value, dgv.Cells[4].Value,
                            category.GetCategoryByProduct(dgv.Cells[0].Value.ToString()) , dgv.Cells[5].Value);
                    }
                }


                CrpStock crp = new CrpStock();
                crp.Database.Tables["Stock"].SetDataSource(Stock);
                crpReportViewer.ReportSource = null;
              crp.SetParameterValue("BusinessName", MyPrinter.CompanyName= string.IsNullOrEmpty(MyPrinter.CompanyName) ? "Business Name" : MyPrinter.CompanyName);
              crp.SetParameterValue("ReportTitle", MyPrinter.printTitle = string.IsNullOrEmpty(MyPrinter.printTitle)?"Report":MyPrinter.printTitle);
                crpReportViewer.ReportSource = crp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void SetSalesData(DataGridView data)
        {
            try
            {
                Stock = new DataTable();
                ds = new DataSet();
                if (data.RowCount > 0)
                {

                    Stock.Columns.AddRange(new DataColumn[10]
                    {
                        new DataColumn("InvoiceID", typeof(string)),
                        new DataColumn("BillNo", typeof(string)),
                        new DataColumn("Amount", typeof(Decimal)),
                        new DataColumn("Qty", typeof(int)),
                        new DataColumn("Discount", typeof(Decimal)),
                        new DataColumn("Paid", typeof(Decimal)),
                        new DataColumn("Sale_type", typeof(string)),
                        new DataColumn("Status", typeof(string)),
                        new DataColumn("Total", typeof(Decimal)), 
                        new DataColumn("Sold_date", typeof(string)),
                    });
                    foreach (DataGridViewRow dgv in data.Rows)
                    {
                        Stock.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value,
                            dgv.Cells[2].Value, dgv.Cells[3].Value,
                        dgv.Cells[4].Value.ToString(), dgv.Cells[5].Value,
                        dgv.Cells[6].Value.ToString(), dgv.Cells[7].Value,
                        dgv.Cells[8].Value.ToString(), dgv.Cells[9].Value.ToString());
                    }
                }


                crpSales crp = new crpSales();
                crp.Database.Tables["Sales"].SetDataSource(Stock);
                crpReportViewer.ReportSource = null;
                crp.SetParameterValue("BusinessName", MyPrinter.CompanyName = string.IsNullOrEmpty(MyPrinter.CompanyName) ? "Business Name" : MyPrinter.CompanyName);
                crp.SetParameterValue("ReportTitle", MyPrinter.printTitle = string.IsNullOrEmpty(MyPrinter.printTitle) ? "Report" : MyPrinter.printTitle);
                crpReportViewer.ReportSource = crp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
