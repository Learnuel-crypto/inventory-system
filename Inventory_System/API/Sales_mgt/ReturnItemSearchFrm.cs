using Inventory_System.Models;
using System;
using System.Windows.Forms;

namespace Inventory_System.API.Sales_mgt
{
    public partial class ReturnItemSearchFrm : Form
    {
        private Sales sales = Factory.CreateSales();
        public ReturnItemSearchFrm()
        {
            InitializeComponent();
            txtSearch.Focus();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            try
            {
                txtSearch.Focus();
                if (string.IsNullOrEmpty(txtSearch.Text))
                    throw new Exception("Enter invoice number or bill number");
                var search = sales.FindSale(txtSearch.Text.Trim());
                if (string.IsNullOrEmpty(search))
                {
                    MessageBox.Show("Invoice or Billno was NOT Found", "Search completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Hide();
                    var returnPurchase = new ReturnPurchaseFrm(search);
                    returnPurchase.Show(); 
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }
    }
}
