using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncryptPassword35;
using Inventory_System.Model;
using Inventory_System.Model.Helper;
using Inventory_System.API.User_Security;

namespace Inventory_System.API
{
    public partial class ResetLoginFrm : Form
    {
        private IUsers user = Factory.CreateUser();
        public ResetLoginFrm()
        {
            InitializeComponent();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCurrentPass.Text))
                {
                    txtCurrentPass.Focus();
                    throw new Exception("Enter current password");
                }
                if (string.IsNullOrEmpty(txtNewPass.Text))
                {
                    txtNewPass.Focus();
                    throw new Exception("Enter new password");
                }
                if (string.IsNullOrEmpty(txtConfirmPass.Text))
                {
                    txtConfirmPass.Focus();
                    throw new Exception("Confirm new password");
                }

                if (SecurePassword.Encrypt(txtCurrentPass.Text.Trim()) != Users.LoggedPassword)
                    throw new Exception("Current password is incorrect");
                if (SecurePassword.Encrypt(txtNewPass.Text.Trim()) !=
                    SecurePassword.Encrypt(txtConfirmPass.Text.Trim()))
                    throw new Exception("Password mismatched");
                user.NewPassword = txtConfirmPass.Text.Trim();
                user.ResetPassword(user,Users.LoggedUserID);
               
                txtConfirmPass.Clear();
                txtCurrentPass.Clear();
                txtNewPass.Clear(); 
                MessageBox.Show( "Password reset was succesful", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogTimer.Start();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtLoggedInPassword_TextChanged(object sender, EventArgs e)
        {
            txtLoggedInPassword.UseSystemPasswordChar = true;
        }

        private void txtCurrentPass_TextChanged(object sender, EventArgs e)
        {
            txtCurrentPass.UseSystemPasswordChar = true;
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = true;
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            txtConfirmPass.UseSystemPasswordChar = true;
        }

        private void btnResetUsername_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewUsername.Text))
                {
                    txtNewUsername.Focus();
                    throw new Exception("Enter new username");
                }
                if (string.IsNullOrEmpty(txtLoggedInPassword.Text))
                {
                    txtLoggedInPassword.Focus();
                    throw new Exception("Enter current password");
                }

                if (SecurePassword.Encrypt(txtLoggedInPassword.Text.Trim()) != Users.LoggedPassword)
                    throw new Exception("Current password is incorrect");
                user.Newusername = txtNewUsername.Text;
                user.ResetUsername(user,Users.LoggedUserID); 
                MessageBox.Show("Username reset was succesful", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                txtNewUsername.Clear();
                txtLoggedInPassword.Clear();
                LogTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LogTimer_Tick(object sender, EventArgs e)
        {
            if (Users.IsLoggedIn == false)
            {
                var logoutFrm = new LogoutFrm();
                LogTimer.Stop();
                logoutFrm.ShowDialog();
                LogTimer.Start();
            }
        }
    }
}
