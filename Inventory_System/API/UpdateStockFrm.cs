using Inventory_System.Models;
using System;
using System.Windows.Forms;

namespace Inventory_System.API
{
    public partial class UpdateStockFrm : Form
    {
        private Category category = Factory.CreateCategory();
        private Products product = Factory.CreateProducts();
        public UpdateStockFrm(Products myProduct,Category cat)
        {
            category =   cat;
            product =  myProduct;
            InitializeComponent(); 
            txtDescription.Text = product.Description;
            txtPacking.Text = product.Packing.ToString();
            txtPrice.Text = product.SellingPrice.ToString();

        }

        private void UpdateStockFrm_Load(object sender, EventArgs e)
        {
            combBrand.DataSource = category.Display("");
            combBrand.DisplayMember = "Brandname";
            combBrand.ValueMember = "BrandID";
            combBrand.Text = category.BrendName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                product.Description = txtDescription.Text.Trim();
                product.BrendName = combBrand.Text;
                product.Quantity = Int32.Parse(txtQuantity.Text);
                product.Packing = Int32.Parse(txtPacking.Text.Trim());
                product.SellingPrice = Convert.ToDecimal(txtPrice.Text.Trim());
                product.Update();
                MessageBox.Show("Update was successfull", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var catFrm = new CategoryFrm();
            catFrm.ShowDialog();
            combBrand.DataSource = category.Display("");
        }
    }
}
