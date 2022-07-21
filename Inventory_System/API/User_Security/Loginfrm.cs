using System;
using System.Windows.Forms;
using Inventory_System.API;
using Inventory_System.Model;
using Inventory_System.Model.Helper;
using Inventory_System.API.User_Security;

namespace Inventory_System
{
    public partial class LoginFrm : Form
    {
        private IUsers user = Factory.CreateNewUsers();
        private int errorCount = 0;
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            try
            {
                if (user.IfUsersExist() == false)
                {
                    linkRegister.Visible = true;
                    btnLogin.Enabled = false;
                }
                else
                {
                    linkRegister.Visible = false;
                    btnLogin.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            try
            {
                var registration = new RegistrationFrm();
                this.Hide();
                registration.ShowDialog();
                if (user.IfUsersExist() == false)
                {
                    linkRegister.Visible = true;
                    btnLogin.Enabled = false;
                }
                else
                {
                    linkRegister.Visible = false;
                    btnLogin.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        { 
            try
            {
                if(string.IsNullOrEmpty(txtUsername.Text))
                    throw new Exception("Enter username");
                if(string.IsNullOrEmpty(txtPassword.Text))
                    throw new Exception("Enter password");
                if (user.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim()))
                {
                    UserActivity.RecordActivity("Login");
                    errorCount = 0;
                    //DISPLAY MAIN FORM
                    var dashboard = new DashboardFrm();
                    this.Hide();
                    dashboard.Show();
                }
                else
                {
                    errorCount++;
                    MessageBox.Show("Incorrect username or password", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //show forgot password after times error trial
                if (errorCount >= 3)
                {
                    linkForgotPass.Visible = true;
                }
                else
                {
                    linkForgotPass.Visible = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Login error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void tctExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Sure you want to exit?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void LoginFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!string.IsNullOrEmpty(Users.LoggedUserID))
                    UserActivity.RecordActivity("Application shutdown");
            Application.Exit();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                btnLogin.PerformClick();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                btnLogin.PerformClick();
            }
        }

        private void linkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var forgotPass = new ForgotPassword();
            forgotPass.ShowDialog();
        }
    }
    }
