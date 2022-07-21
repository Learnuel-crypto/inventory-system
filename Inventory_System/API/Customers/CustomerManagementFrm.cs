using Inventory_System.API.Notification;
using Inventory_System.Model;
using Inventory_System.Models;
using System;
using System.Windows.Forms;

namespace Inventory_System.API.Customers
{
    public partial class CustomerManagementFrm : Form
    {
        private Customer customer = Factory.CreateCustomer();
        private Cheque cheque = Factory.CreateCheque();
        public CustomerManagementFrm(int role)
        {
            InitializeComponent();
            if (role != 1)
                throw new Exception("Access Denied: you do not have required privilege");
        }

        private void CustomerManagementFrm_Load(object sender, EventArgs e)
        {
            DataGridStyle.StyleDatagridviewFixed(dgvCustomer); 
            dgvCustomer.DataSource = customer.Display("");
            dgvCustomer.Columns[0].Visible = false;
        }

        void Clear()
        {
            txtName.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            lblAmount.Text = "0.00";
            lblBalance.Text = "0.00";
            lblPaid.Text = "0.00";
            customer.CusID = null;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = customer.Display(txtSearch.Text.Trim());
            Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                customer.Name = txtName.Text.Trim();
                customer.Contact = txtContact.Text.Trim();
                customer.Address = txtAddress.Text.Trim();
                customer.Add();
                Clear();
                dgvCustomer.DataSource = customer.Display("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (customer.CusID == null)
                    throw new Exception("Select a customer to update");
                customer.Name = txtName.Text.Trim();
                customer.Contact = txtContact.Text.Trim();
                customer.Address = txtAddress.Text.Trim();
                customer.Update();
                Clear();
                dgvCustomer.DataSource = customer.Display("");
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
                if (customer.CusID == null)
                    throw new Exception("Select a customer to delete");
                if (MessageBox.Show("Do you want to delete ?", "Confirm Delete", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    customer.Delete();
                    Clear();
                    dgvCustomer.DataSource = customer.Display("");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvCustomer_Click(object sender, EventArgs e)
        {

            if (dgvCustomer.RowCount > 0)
            {
              customer.CusID = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();
              txtName.Text=  customer.Name = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
              txtContact.Text= dgvCustomer.SelectedRows[0].Cells[2].Value.ToString();
              txtAddress.Text= dgvCustomer.SelectedRows[0].Cells[3].Value.ToString();
              cheque.GetPayments(customer.CusID);
              lblBalance.Text = Cheque.ChequeBalance.ToString();
              lblAmount.Text = Cheque.CostAmount.ToString();
              lblPaid.Text = Cheque.Paid.ToString();
            }
            else
            {
                MessageBox.Show("No record to select", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkMakePayment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (customer.CusID != null)
            {
                if (lblBalance.Text != "0.00")
                {
                    var cheque = new ChequePaymentFrm(customer);
                    cheque.ShowDialog();
                    Clear();
                }
                else
                {
                    MessageBox.Show("There is no balance to be pay", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
               
            }
            else
            {
                MessageBox.Show("Select a record to make payment", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkPrintStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var print = new PrinterNotificationFrm();
            print.ShowDialog();
            if (MyPrinter.Print == true)
                MyPrinter.PrintRecordsPortrate(dgvCustomer, MyPrinter.printTitle);

        }
    }
}
