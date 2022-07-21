using Inventory_System.Models;
using System;
using System.Windows.Forms;
using Inventory_System.Model;

namespace Inventory_System.API
{
    public partial class RegistrationFrm : Form
    {
         
        Staff staff = new Staff();
        private bool FirstRun = false;
        public RegistrationFrm()
        {
            InitializeComponent();
            FirstRun = true;
        }
        public RegistrationFrm(int role)
        {
            InitializeComponent();
            FirstRun = false;
            if(role !=1)
                throw  new Exception("Access Denied: you do not have required privilege");
            tctExit.Text = "Close";
        }
        void Clear()
        {
            txtName.Clear();
            txtContact.Clear(); ;
             txtCNIC.Clear();
             txtusername.Clear();
            txtPassword.Clear();
            txtConfirmPass.Clear();
            
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                    throw new Exception("enter name");
                Validation.Name(txtName.Text);
                if (string.IsNullOrEmpty(txtContact.Text))
                    throw new Exception("Enter contact");
                if (string.IsNullOrEmpty(txtCNIC.Text))
                    throw new Exception("Enter CNIC");
                Validation.CNIC(txtCNIC.Text);
                if (string.IsNullOrEmpty(txtusername.Text))
                    throw new Exception("Enter username");
                if (string.IsNullOrEmpty(txtPassword.Text))
                    throw new Exception("Enter Password");
                if (string.IsNullOrEmpty(txtConfirmPass.Text))
                    throw new Exception("Retype Password");
                if (combRole.Text.Trim() != "Admin" && combRole.Text.Trim() != "User")
                    throw new Exception("Please select user Role");
                if (txtPassword.Text.Trim() !=txtConfirmPass.Text.Trim())
                    throw new Exception("Password Mismatch");
                
                staff.Name = txtName.Text.Trim();
                staff.Contact = txtContact.Text.Trim();
                staff.CNIC = txtCNIC.Text.Trim();
                staff.Username = txtusername.Text.Trim();
                staff.Password = txtPassword.Text.Trim();
                staff.Role = combRole.Text.Trim();
                if (FirstRun == true && combRole.Text == "User")
                    throw new Exception("First user must be an admin");
                 staff.RegisterStaff(FirstRun); 
                 Clear();
                 MessageBox.Show("Staff Registered Successfully", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 if (FirstRun == true)
                 {
                     var login = new LoginFrm();
                     login.Show();
                     this.Hide();
                }
                  
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tctExit_Click(object sender, EventArgs e)
        {
            if (tctExit.Text == "Close")
            {
                this.Close();
            }
            else
            {
                this.Hide();
                var login = new LoginFrm();
                login.Show();
            }
           
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            txtConfirmPass.UseSystemPasswordChar = true;
        }

        private void RegistrationFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FirstRun == true)
            {
                var login = new LoginFrm();
                login.Show();
                this.Hide();
            }
            else
            {
                this.Close();
            }
        }
    }
}
