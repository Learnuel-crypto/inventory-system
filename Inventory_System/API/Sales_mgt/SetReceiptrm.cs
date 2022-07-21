using System;
using System.Windows.Forms;
using Inventory_System.Model;

namespace Inventory_System.API.Sales_mgt
{
    public partial class SetReceiptrm : Form
    {
        public SetReceiptrm(int roleid)
        {
            InitializeComponent();
            if (roleid != 1)
                throw new Exception("Access Denied: you do not have required privilege");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                    throw new Exception("Enter company/business name");
                if (string.IsNullOrEmpty(txtContact.Text))
                    throw new Exception("Enter company/business contact");
                if (string.IsNullOrEmpty(txtAddress.Text))
                    throw new Exception("Enter company/business address");
                MyPrinter.CompanyName = txtName.Text.Trim();
               MyPrinter.Contact= txtContact.Text.Trim();
                MyPrinter.Address = txtAddress.Text.Trim();
                MyPrinter.SetReceiptDetails();
                txtName.Clear();
                txtContact.Clear();
                txtAddress.Clear();
                MessageBox.Show("Reeipt details set successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Details Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SetReceiptrm_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void SetReceiptrm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==(char)Keys.Escape)
                this.Close();
        }

        private void SetReceiptrm_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
