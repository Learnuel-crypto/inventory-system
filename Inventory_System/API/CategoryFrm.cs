using System;
using System.Drawing;
using System.Windows.Forms;
using Inventory_System.Model;
using Inventory_System.Models;

namespace Inventory_System.API
{
    public partial class CategoryFrm : Form
    {
        private Category category = Factory.CreateCategory();
        public CategoryFrm()
        {
            InitializeComponent();
        }

        private void CategoryFrm_Load(object sender, EventArgs e)
        {
            DataGridStyle.StyleDatagridviewFixed(dgvCategory);
            dgvCategory.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            dgvCategory.DataSource = category.Display("");
            dgvCategory.Columns[0].Visible = false;
        }
        
        private void dgvCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategory.RowCount > 0)
            {
                category.BrendID = dgvCategory.SelectedRows[0].Cells[0].Value.ToString();
                txtBradName.Text = dgvCategory.SelectedRows[0].Cells[1].Value.ToString();
                txtBradName.Focus();
            }
        }

        void Clear()
        {
            dgvCategory.DataSource = category.Display("");
            txtBradName.Clear();
            category.BrendID = null;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                category.BrendName = txtBradName.Text;
                category.Add();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                    if(category.BrendID==null)
                        throw new Exception("Select a category to update");
                    category.BrendName = txtBradName.Text.Trim();
                    category.Update();
                    Clear();
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
                if (category.BrendID == null)
                    throw new Exception("Select a category to delete");
                category.Delete();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBradName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==(char)Keys.Enter)
                btnAdd.PerformClick();
        }
    }
}
