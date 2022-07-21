using System;
using System.Windows.Forms;
using Inventory_System.Model;
using Inventory_System.Models;

namespace Inventory_System.API.Customers
{
    public partial class ChequePaymentFrm : Form
    {
        private Cheque customer = Factory.CreateCheque();
        private string saleid;
        public ChequePaymentFrm(Customer details)
        {
            InitializeComponent();
            customer.CusID = details.CusID;
            lblCustomerName.Text = details.Name;
        }

        private void ChequePaymentFrm_Load(object sender, EventArgs e)
        {
            DataGridStyle.StyleDatagridviewFixed(dgvCustomer);
            dgvCustomer.DataSource = customer.DisplayCredit(customer.CusID);
            txtAmount.Focus();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(saleid))
                    throw new Exception("Select a cheque details to pay");
                if (string.IsNullOrEmpty(txtAmount.Text))
                    throw new Exception("Enter amount to pay");
                var amount = Convert.ToDecimal(lblAmount.Text);
                var paid = Convert.ToDecimal(lblPaid.Text);
                var balance = Convert.ToDecimal(lblBalance.Text);
                customer.Amount= Convert.ToDecimal(txtAmount.Text);
                if (customer.Amount > balance)
                    throw new Exception("Amount can't exceed cheque balance");
                customer.PayCheque(saleid);

                txtAmount.Clear();
                lblBalance.Text = "0.00";
                lblPaid.Text = "0.00";
                lblAmount.Text = "0.00";
                saleid = null;
                dgvCustomer.DataSource = customer.DisplayCredit(customer.CusID);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || (char.IsPunctuation(e.KeyChar) || e.KeyChar == (char)Keys.Back));
        }

        private void dgvCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.RowCount > 0)
            {
                saleid = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();
                lblAmount.Text = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
                lblPaid.Text = dgvCustomer.SelectedRows[0].Cells[2].Value.ToString();
                lblBalance.Text = dgvCustomer.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue ==(char)Keys.Enter)
                btnPay.PerformClick();
        }
    }
}
