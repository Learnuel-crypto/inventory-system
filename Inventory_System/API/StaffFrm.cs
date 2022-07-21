using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_System.Model;
using Inventory_System.Models;
using Inventory_System.API.Notification;

namespace Inventory_System.API
{
    public partial class StaffFrm : Form
    {
        private Staff staff = Factory.CreateStaff();
        private IUsers user = Factory.CreateNewUsers();
        public StaffFrm(int roleid)
        {
            InitializeComponent();
            if (roleid != 1)
                throw new Exception("Access Denied: you do not have required privilege");
        }

        private void StaffFrm_Load(object sender, EventArgs e)
        {
            DataGridStyle.StyleDatagridviewFixed(dgvStaff);
            dgvStaff.DataSource = staff.Display("");
            dgvStaff.Columns[0].Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvStaff.DataSource = staff.Display(txtSearch.Text);
        }

        private void dgvStaff_Click(object sender, EventArgs e)
        {
            if (dgvStaff.RowCount > 0)
            {
                staff.StaffID = dgvStaff.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dgvStaff.SelectedRows[0].Cells[1].Value.ToString();
               txtContact.Text = dgvStaff.SelectedRows[0].Cells[2].Value.ToString();
               txtCNIC.Text = dgvStaff.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void linkAccountInfor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (staff.StaffID == null)
                    throw new Exception("Select a staff to view account details");
                if (staff.GetAccountDetails().Rows.Count > 0)
                {
                    foreach (DataRow row in staff.GetAccountDetails().Rows)
                    {
                        user.UserID = row["UserID"].ToString();
                        txtusername.Text = row["UserName"].ToString();
                        txtPassword.Text = row["Password"].ToString();
                        combRole.Text = row["Role"].ToString();
                        
                    }
                    btnAccountUpdate.Enabled = true;
                }
                else
                {
                    btnAccountUpdate.Enabled = false;
                }

                linkAccountInfor.Enabled = false;
                panUserAccount.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            panUserAccount.Visible = false;
            linkAccountInfor.Enabled = true;
        }

        void Clear()
        {
             txtCNIC.Clear();
           txtName.Clear();
            txtContact.Clear();
            txtPassword.Clear();
            txtusername.Clear();
            panUserAccount.Visible = false;
            linkAccountInfor.Enabled = true;
            staff.StaffID = null; 
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (staff.StaffID == null)
                    throw new Exception("Select a staff to delete");
                if (string.IsNullOrEmpty(txtName.Text))
                    throw new Exception("Enter staff name");
                Validation.Name(txtName.Text);
                if (string.IsNullOrEmpty(txtContact.Text))
                     throw new Exception("Enter contact");
                Validation.Contact(txtContact.Text,11,11);
                if (string.IsNullOrEmpty(txtCNIC.Text))
                    throw new Exception("Enter CNIC digits");
                staff.CNIC = txtCNIC.Text;
                staff.Name = txtName.Text;
                staff.Contact = txtContact.Text;
                staff.UpdateStaff();
                dgvStaff.DataSource = staff.Display("");
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
                if (staff.StaffID == null)
                        throw new Exception("Select a staff to delete");

                staff.DeleteStaff(Users.LoggedUserID);
                dgvStaff.DataSource = staff.Display("");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void linkPrintStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var print = new PrinterNotificationFrm();
            print.ShowDialog();
            if (MyPrinter.Print == true)
                MyPrinter.PrintRecordsPortrate(dgvStaff, MyPrinter.printTitle);

        }
    
    }
}
