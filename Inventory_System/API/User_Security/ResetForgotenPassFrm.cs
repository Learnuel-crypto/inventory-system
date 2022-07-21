using System;
using System.Windows.Forms;
using EncryptPassword35;
using Inventory_System.Model;

namespace Inventory_System.API.User_Security
{
    public partial class ResetForgotenPassFrm : Form
    {
        private IUsers user = Factory.CreateUser();
        public ResetForgotenPassFrm(string username)
        {
            InitializeComponent();
            lblUsername.Text = username;
        }

        private void ResetForgotenPassFrm_Load(object sender, EventArgs e)
        {
            txtNewPassword.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewPassword.Text))
                {
                    txtNewPassword.Focus();
                    throw new Exception("Enter new password");
                }

                if (string.IsNullOrEmpty(txtConfirmPass.Text))
                {
                    txtConfirmPass.Focus();
                    throw new Exception("Confirm new password"); 
                }

                if (SecurePassword.Encrypt(txtNewPassword.Text.Trim()) !=
                    SecurePassword.Encrypt(txtConfirmPass.Text.Trim()))
                    throw new Exception("Password mismatched");
                user.Username = lblUsername.Text;
                user.NewPassword = txtNewPassword.Text;
                user.ForgottonPassword(user);
                MessageBox.Show("Password reset was successful", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = true;
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            txtConfirmPass.UseSystemPasswordChar = true;
        }
    }
}
