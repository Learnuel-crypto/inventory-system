using System;
using System.Windows.Forms;
using Inventory_System.Model;
using Inventory_System.Models;
using Inventory_System.API.Notification;

namespace Inventory_System.API.Sales_mgt
{
    public partial class ItemsViewFrm : Form
    {
        private Sales sales = Factory.CreateSales();
        private Cheque chequeSale = Factory.CreateCheque();
        public bool Shown;
        public ItemsViewFrm()
        {
            InitializeComponent();
        }

        private void ItemsViewFrm_Load(object sender, EventArgs e)
        {
            DataGridStyle.StyleDatagridviewFixed(dgvSoldItems); 
            Shown = true;
        }

        public void LoadData(string salesid)
        {
            lblInvoiceID.Text = salesid;
            this.Text = "Sale Invoice Details";
            dgvSoldItems.DataSource = sales.DisplayItemsBySaleID(salesid);
            dgvSoldItems.Columns[0].Visible = false;
            if(Shown==false)
                 this.Show();
            Shown = false;
        }
        /// <summary>
        /// Get itmes that where returned
        /// </summary>
        /// <param name="salesid"></param>
        public void LoadReturnedData(string salesid)
        {
            lblInvoiceID.Text = salesid;
            this.Text = "Sale Invoice Details";
            dgvSoldItems.DataSource = sales.DisplayItemsReturned(salesid);
            dgvSoldItems.Columns[0].Visible = false;
            if (Shown == false)
                this.Show();
            Shown = false;
        }
        /// <summary>
        /// Get Customer Detail and Cheque infor
        /// </summary>
        /// <param name="salesid"></param>
        public void LoadCustomerData(string salesid)
        {
            lblInvoiceID.Text = salesid;
            this.Text = "Customer Cheque Details";
            dgvSoldItems.DataSource = chequeSale.DisplayBySaleID(salesid); 
            if (Shown == false)
                this.Show();
            Shown = false;
        }
        private void linkPrintStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.TopMost = false;
            this.Hide(); 
            var print = new PrinterNotificationFrm();
            print.ShowDialog();
            if (MyPrinter.Print==true)
            {
                MyPrinter.PrintRecordsPortrate(dgvSoldItems, MyPrinter.printTitle);
                this.Show();
                this.TopMost = true;
            }
            else
            {
                this.Show();
                this.TopMost = true;
            }
        }
    }
}
