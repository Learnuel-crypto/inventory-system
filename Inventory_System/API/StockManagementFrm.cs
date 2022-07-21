using Inventory_System.API.Notification;
using Inventory_System.API.Reports;
using Inventory_System.Model;
using Inventory_System.Models;
using System;
using System.Windows.Forms;

namespace Inventory_System.API
{
    public partial class StockManagementFrm : Form
    {
        private Category category = Factory.CreateCategory();
        private Products product = Factory.CreateProducts();
        public StockManagementFrm(int roleid)
        {
            InitializeComponent();
            if (roleid != 1)
                throw new Exception("Access Denied: you do not have required privilege");
            comboBox1.DataSource = category.Display("");
            comboBox1.DisplayMember = "Brandname";
            comboBox1.ValueMember = "BrandID";
        }
        void Clear()
        {
            txtDescription.Clear();
            txtQuantity.Clear();
            txtPacking.Clear();
            txtPrice.Clear();
        }
        private void dgvStock_Click(object sender, EventArgs e)
        {

            if (dgvStock.RowCount > 0)
            {
                try
                {
                    product.ProID = dgvStock.SelectedRows[0].Cells[0].Value.ToString();
                    combBrand.Text = category.BrendName = category.GetCategoryByProduct(product.ProID);
                    txtDescription.Text = product.Description = dgvStock.SelectedRows[0].Cells[1].Value.ToString();
                    txtQuantity.Text = dgvStock.SelectedRows[0].Cells[3].Value.ToString();
                    txtPrice.Text = dgvStock.SelectedRows[0].Cells[2].Value.ToString();
                    txtPacking.Text = dgvStock.SelectedRows[0].Cells[4].Value.ToString();

                    product.Quantity = Int32.Parse(dgvStock.SelectedRows[0].Cells[3].Value.ToString());
                    product.Packing = Int32.Parse(dgvStock.SelectedRows[0].Cells[4].Value.ToString());
                    product.SellingPrice = Convert.ToDecimal(dgvStock.SelectedRows[0].Cells[2].Value.ToString());
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void StockManagementFrm_Load(object sender, EventArgs e)
        {
            DataGridStyle.StyleDatagridview(dgvStock);
            dgvStock.DataSource = product.Display("");
            dgvStock.Columns[0].Visible = false;
            combBrand.DataSource = category.Display("");
            combBrand.DisplayMember = "Brandname";
            combBrand.ValueMember = "BrandID";
             
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var catFrm = new CategoryFrm();
            catFrm.ShowDialog(); 
            combBrand.DataSource = category.Display("");
            combBrand.DisplayMember = "Brandname";
            combBrand.ValueMember = "BrandID"; 
        }

        private void linkUpdateStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (product.ProID == null)
                    throw new Exception("Select a stock to update");

                var updateStock = new UpdateStockFrm(product, category);
                updateStock.ShowDialog();
                Clear();
                dgvStock.DataSource = product.Display("");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (checkAll.Checked)
            {
                dgvStock.DataSource = product.Display(txtSearch.Text.Trim());
            }else if (!checkAll.Checked)
            {
                dgvStock.DataSource = product.Display(txtSearch.Text.Trim(),combBrand.Text);
            }

            Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                product.Description = txtDescription.Text.Trim();
                product.BrendName = combBrand.Text;
                if (Int32.Parse(txtQuantity.Text) == 0)
                    throw new Exception("Quantity to be added cannot be zero(0) or negative(-)");
                product.Quantity = Int32.Parse(txtQuantity.Text);
                product.Packing = Int32.Parse(txtPacking.Text.Trim());
                product.SellingPrice = Convert.ToDecimal(txtPrice.Text.Trim());
                product.Add();
                Clear();
                dgvStock.DataSource = product.Display("");
                comboBox1.DataSource = category.Display("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (product.ProID == null)
                    throw new Exception("Select a stock to delete");
                if (MessageBox.Show("Are you sure you want to delete ?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                    DialogResult.Yes)
                {
                    product.Delete();
                    Clear();
                    dgvStock.DataSource = product.Display("");
                    comboBox1.DataSource = category.Display("");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            Clear();
            dgvStock.DataSource = product.DisplayByDate(dtpFrom.Value);
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            Clear();
            dgvStock.DataSource = product.DisplayBetweenDate(dtpFrom.Value, dtpTo.Value);
        }

        private void linkRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
            dgvStock.DataSource = product.Display("");
            checkAll.Checked = false;
            combBrand.DataSource = category.Display("");
            combBrand.DisplayMember = "Brandname";
            combBrand.ValueMember = "BrandID";
        }

        private void linkGenReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvStock.RowCount <= 0)
                    throw new Exception("There no records to generate report from");
                var printFrm = new PrinterNotificationFrm();
                printFrm.ShowDialog();
                if (MyPrinter.Print)
                {
                    var reportForm = new ReportsFrm(dgvStock);
                    reportForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            e.Handled = !(char.IsNumber(e.KeyChar)  || e.KeyChar == (char)Keys.Back);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvStock.DataSource = product.DisplayByBrand(comboBox1.Text);
            Clear();
        }

        private void linkPrintStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var print = new PrinterNotificationFrm();
            print.ShowDialog();
            if (MyPrinter.Print == true)
                MyPrinter.PrintRecords(dgvStock, MyPrinter.printTitle);
        }
    }
}
