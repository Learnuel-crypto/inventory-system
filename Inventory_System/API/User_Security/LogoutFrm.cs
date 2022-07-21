using Inventory_System.Model.Helper;
using System;
using System.Windows.Forms;
using Inventory_System.Model;

namespace Inventory_System.API.User_Security
{
    public partial class LogoutFrm : Form
    {
        private IUsers user = Factory.CreateUser();
        public LogoutFrm()
        {
            InitializeComponent();
        }

        private void tctExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure you want to exit?", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
            {
                UserActivity.RecordActivity("Application shutdown");
                Application.Exit();

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text))
                    throw new Exception("Enter username");
                if (string.IsNullOrEmpty(txtPassword.Text))
                    throw new Exception("Enter password");
                if (user.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim()))
                {
                    UserActivity.RecordActivity("Login"); 
                    this.Close();
                }
                else
                { 
                    MessageBox.Show("Incorrect username or password", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Login error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue ==(char)Keys.Enter)
                btnLogin.PerformClick();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
                btnLogin.PerformClick();
        }
    }
}
