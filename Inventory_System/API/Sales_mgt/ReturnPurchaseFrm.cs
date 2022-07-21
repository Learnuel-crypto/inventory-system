using System;
using System.Windows.Forms;
using Inventory_System.Model;
using Inventory_System.Models;

namespace Inventory_System.API.Sales_mgt
{
    public partial class ReturnPurchaseFrm : Form
    {
        private Sales sales = Factory.CreateSales();
        public ReturnPurchaseFrm(string foundID)
        {
            InitializeComponent();
            sales.SalesID = foundID;
        }

        private void ReturnPurchaseFrm_Load(object sender, EventArgs e)
        {
            DataGridStyle.StyleDatagridviewFixed(dgvStock);
            DataGridStyle.StyleDatagridviewFixed(dgvSoldItems);
            dgvStock.DataSource = sales.Display(sales.SalesID);
            dgvSoldItems.DataSource = sales.DisplayItemsBySaleID(sales.SalesID);
            dgvSoldItems.Columns[0].Visible = false;
        }

        private void btnReturnSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSoldItems.RowCount <= 0)
                    throw new Exception("No product(s) to return");
                //check if there are quantity that can be returned

                if (sales.BrendID == null)
                    throw new Exception("Select item to return");
                if (MessageBox.Show("Are you sure you want to return sale?", "Confirm Operation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //show box to enter quantity
                    var qtyReturn = new ReturnItemFrm(sales.Quantity); 
                    qtyReturn.ShowDialog();
                    if (qtyReturn.Return)
                    {
                        if (sales.Discount != 0.00m)
                        {
                            var cost = qtyReturn.Qty * sales.SellingPrice;
                            sales.TotalAmount = cost -
                                                ((qtyReturn.Qty * sales.SellingPrice) * sales.Discount / 100.00m);
                        }
                        else
                        {
                            sales.TotalAmount = qtyReturn.Qty * sales.SellingPrice;
                        }
                        sales.Status = "Returned";
                        sales.Quantity = qtyReturn.Qty;
                        sales.ReturnSale(sales);
                        MessageBox.Show("Product(s) Returned Successfully", "Completed", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        dgvStock.DataSource = sales.Display(sales.SalesID);
                        dgvSoldItems.DataSource = sales.DisplayItemsBySaleID(sales.SalesID);
                        qtyReturn.Return = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvSoldItems_Click(object sender, EventArgs e)
        {
            if (dgvSoldItems.RowCount > 0)
            {
               
                sales.SalesID = dgvStock.Rows[0].Cells[0].Value.ToString();
                sales.BrendID = dgvSoldItems.SelectedRows[0].Cells[0].Value.ToString();
                sales.Quantity =Int32.Parse( dgvSoldItems.SelectedRows[0].Cells[3].Value.ToString());
                sales.TotalAmount =Convert.ToDecimal( dgvSoldItems.SelectedRows[0].Cells[6].Value.ToString());
                sales.SellingPrice =Convert.ToDecimal( dgvSoldItems.SelectedRows[0].Cells[4].Value.ToString());
                sales.Discount =Convert.ToDecimal( dgvSoldItems.SelectedRows[0].Cells[5].Value.ToString());
            }
        }

        private void btnReturnall_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSoldItems.RowCount <= 0)
                    throw new Exception("No product(s) to return"); 
                if (MessageBox.Show("Are you sure you want to return sale?", "Confirm Operation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    
                        sales.Status = "Returned";
                        sales.ReturnSale(dgvSoldItems);
                        MessageBox.Show("Product Returned Successfully", "Completed", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        dgvStock.DataSource = sales.Display(sales.SalesID);
                        dgvSoldItems.DataSource = sales.DisplayItemsBySaleID(sales.SalesID);
                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
