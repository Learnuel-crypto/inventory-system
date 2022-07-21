using Inventory_System.Models;
using System;
using System.Windows.Forms;

namespace Inventory_System.API.Customers
{
    public partial class RegisterCustomer : Form
    {
        private Customer customer = Factory.CreateCustomer();
       
        /// <summary>
        /// Registration activity eithere sales or registration
        /// </summary>
        /// <param name="activity"></param>
        public RegisterCustomer()
        {
            InitializeComponent(); 
        }
        /// <summary>
        /// Get the new customer details
        /// </summary>
        /// <returns></returns>
        public Customer GetCustomerDetails()
        {
            return customer;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                customer.Name = txtName.Text.Trim();
                customer.Contact = txtContact.Text.Trim();
                customer.Address = txtAddress.Text.Trim(); 
                customer.Add(); 
                    txtName.Clear();
                    txtContact.Clear();
                    txtAddress.Clear(); 
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Details Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RegisterCustomer_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            customer.Name = null;
            this.Close();
        }

        private void RegisterCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char) Keys.Escape)
            {
                customer.Name = null;
                this.Close();
            }
                
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
