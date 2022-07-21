using Inventory_System.API.Notification;
using Inventory_System.Model;
using Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System.API.Sales_mgt
{
    public partial class ReturneditemsMgtFrm : Form
    {
        private Sales sale = Factory.CreateSales();
        public ReturneditemsMgtFrm()
        {
            InitializeComponent();
        }

        private void linkPrintStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var print = new PrinterNotificationFrm();
            print.ShowDialog();
            if (MyPrinter.Print == true)
                MyPrinter.PrintRecords(dgvItems, MyPrinter.printTitle);
        }

        private void ReturneditemsMgtFrm_Load(object sender, EventArgs e)
        {
            DataGridStyle.StyleDatagridview(dgvItems);
            dgvItems.DataSource = sale.SearchItemsReturned("");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvItems.DataSource = sale.SearchItemsReturned(txtSearch.Text.Trim());
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            dgvItems.DataSource = sale.SearchItemsReturnedByDate(dtpFrom.Value);
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            dgvItems.DataSource = sale.SearchItemsReturnedBetweenDate(dtpFrom.Value,dtpTo.Value);
        }

        private void linkrefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvItems.DataSource = sale.SearchItemsReturned("");
        }
    }
}
