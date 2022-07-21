using System;
using System.Windows.Forms;
using Inventory_System.Model;
using Inventory_System.Models;

namespace Inventory_System.API
{
    public partial class ProductRegistrationFrm : Form
    {
        private Category category = Factory.CreateCategory();
        private Products product = Factory.CreateProducts();
        private int inforCount = 0;
        public ProductRegistrationFrm(int roleid)
        {
            InitializeComponent();
            if (roleid != 1)
                throw new Exception("Access Denied: you do not have required privilege");
        }

        private void ProductRegistrationFrm_Load(object sender, EventArgs e)
        {
            combBrand.DataSource = category.Display("");
            combBrand.DisplayMember = "Brandname";
            combBrand.ValueMember = "BrandID";
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var catFrm =new CategoryFrm();
            catFrm.ShowDialog();
            combBrand.DataSource = category.Display("");
        }

        void Clear()
        {
            txtBrandName.Clear();
            txtQuantity.Clear();
            txtPacking.Clear();
            txtPrice.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                product.Description = txtBrandName.Text.Trim();
                product.BrendName = combBrand.Text;
                product.Packing = Convert.ToInt32(txtPacking.Text);
                product.Quantity = Convert.ToInt32(txtQuantity.Text); 
                Validation.Amount(txtPrice.Text);
                product.SellingPrice = Convert.ToDecimal(txtPrice.Text);
                product.Add();
                inforCount = 5;
                InforTimer.Start();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void InforTimer_Tick(object sender, EventArgs e)
        {
            inforCount--;
            if (inforCount > 0)
            {
                lblIfor.Visible = true;
            }
            else
            {
                lblIfor.Visible = false;
                InforTimer.Stop();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || (char.IsPunctuation(e.KeyChar) || e.KeyChar == (char)Keys.Back));
        }

        private void txtPacking_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) ||   e.KeyChar == (char)Keys.Back);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) ||  e.KeyChar == (char)Keys.Back);
        }
    }
}
