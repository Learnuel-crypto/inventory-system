using System;
using System.Windows.Forms;
using Inventory_System.Model;
using Inventory_System.Models;
using Inventory_System.API.Notification;
using Inventory_System.API.Reports;

namespace Inventory_System.API.Sales_mgt
{
    public partial class SalesInformationFrm : Form
    {
        private Category category = Factory.CreateCategory();
        private Sales sale = Factory.CreateSales();
        public SalesInformationFrm(int roleid)
        {
            InitializeComponent();
            if (roleid != 1 && roleid != 2)
                throw new Exception("Access Denied: you do not have required privilege");
             
            LoadData();

        }
        public SalesInformationFrm(int roleid,string view) 
        {
            InitializeComponent();
            if (roleid != 1 && roleid != 2)
                throw new Exception("Access Denied: you do not have required privilege");
            
            
            if (view == "Sales")
                rbToday.Checked = true;
            if (view == "Returned")
                rbReturned.Checked = true;
            if (view == "Cheque")
                rbCheque.Checked = true;
        }
        private void linkrefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rbReturned.Checked = false;
            rbToday.Checked = false;
            rbCheque.Checked = false;
            dgvStock.DataSource = sale.Display("");
            if (dgvStock.RowCount > 0)
            {
                DataGridStyle.StyleRowColor(dgvStock);
            }
        }

        private void linkPrintStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var print = new PrinterNotificationFrm();
            print.ShowDialog();
            if (MyPrinter.Print == true) 
                     MyPrinter.PrintRecords(dgvStock, MyPrinter.printTitle);
            
            }

        private void linkGenReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvStock.RowCount > 0)
                {
                    var print = new PrinterNotificationFrm();
                    print.ShowDialog();
                    if (MyPrinter.Print)
                    {
                        var report = new ReportsFrm();
                        report.SetSalesData(dgvStock);
                        report.Show(this);
                    }
                }
                else
                {
                    throw new Exception("No record to generate report from");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadData()
        {
            try { 
            dgvStock.DataSource = sale.Display("");
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
}
        private void SalesInformationFrm_Load(object sender, EventArgs e)
        {
           DataGridStyle.StyleDatagridviewFixed(dgvStock);
           if (dgvStock.RowCount > 0)
           {
               DataGridStyle.StyleRowColor(dgvStock);
           }
        }

        private void rbToday_CheckedChanged(object sender, EventArgs e)
        {
            try { 
            if(rbToday.Checked)
                dgvStock.DataSource = sale.DisplayByDate(DateTime.Now.Date);
            if (dgvStock.RowCount > 0)
            {
                DataGridStyle.StyleRowColor(dgvStock);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            dgvStock.DataSource = sale.DisplayByDate(dtpFrom.Value);
            if (dgvStock.RowCount > 0)
            {
                DataGridStyle.StyleRowColor(dgvStock);
            }
        }

        private void dgvStock_Click(object sender, EventArgs e)
        {
            if (dgvStock.RowCount > 0)
            {
                sale.SalesID = dgvStock.SelectedRows[0].Cells[0].Value.ToString();
                sale.Status = dgvStock.SelectedRows[0].Cells[7].Value.ToString();
            }
            else
            {
                MessageBox.Show("No record to select", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkViewItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (sale.SalesID == null)
                    throw new Exception("Select a sale record to view items");
                var viewItems = new ItemsViewFrm(); 
                    viewItems.LoadData(sale.SalesID); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvStock_DoubleClick(object sender, EventArgs e)
        {
            var viewItems = new ItemsViewFrm();
            viewItems.LoadData(sale.SalesID);
        }

        private void linkViewCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (sale.SalesID == null)
                    throw new Exception("Select a sale record to customer");
                var viewItems = new ItemsViewFrm();
                viewItems.LoadCustomerData(sale.SalesID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbReturned_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbReturned.Checked)
                    dgvStock.DataSource = sale.DisplayReturnedSales(rbReturned.Text);
                if (dgvStock.RowCount > 0)
                {
                    DataGridStyle.StyleRowColor(dgvStock);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbCheque_CheckedChanged(object sender, EventArgs e)
        {
            try { 
            if (rbCheque.Checked)
                dgvStock.DataSource = sale.DisplayChequeSales(rbCheque.Text);
            if (dgvStock.RowCount > 0)
            {
                DataGridStyle.StyleRowColor(dgvStock);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            dgvStock.DataSource = sale.DisplayBetweenDate(dtpFrom.Value, dtpTo.Value);
            if (dgvStock.RowCount > 0)
            {
                DataGridStyle.StyleRowColor(dgvStock);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvStock.DataSource = sale.Display(txtSearch.Text.Trim());
            if (dgvStock.RowCount > 0)
            {
                DataGridStyle.StyleRowColor(dgvStock);
            }
        }

        private void linkReturnItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (sale.SalesID == null)
                    throw new Exception("Select a record to view return");
                var returnPurchase = new ReturnPurchaseFrm(sale.SalesID);
                returnPurchase.ShowDialog();
                dgvStock.DataSource = sale.Display("");
            if (dgvStock.RowCount > 0)
            {
                DataGridStyle.StyleRowColor(dgvStock);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkReturneditems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (sale.SalesID == null)
                    throw new Exception("Select a sale record to view items");
                var viewItems = new ItemsViewFrm();
                viewItems.LoadReturnedData(sale.SalesID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
