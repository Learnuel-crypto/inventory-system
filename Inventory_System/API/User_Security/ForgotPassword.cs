using Inventory_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System.API.User_Security
{
    public partial class ForgotPassword : Form
    {
        private Users user = Factory.CreateActivity();
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                txtSearch.Focus();
                if (string.IsNullOrEmpty(txtSearch.Text))
                    throw new Exception("Enter last username or password you know");
                var search =user.FindUserAccount(txtSearch.Text.Trim());
                if (string.IsNullOrEmpty(search))
                {
                    MessageBox.Show("Account was NOT Found", "Search completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Hide();
                    var resetPass = new ResetForgotenPassFrm(search);
                    resetPass.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue ==(char)Keys.Enter)
                btnSearch.PerformClick();
        }
    }
}
