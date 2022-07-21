using System.Windows.Forms;

namespace Inventory_System.API.Sales_mgt
{
    public partial class ReturnItemFrm : Form
    {
        public bool Return = false;
        public int Qty { get; private set; }
        private int SoldQty;
        public ReturnItemFrm(int quantity)
        {
            InitializeComponent();
            SoldQty = quantity;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys KeyData)
        {
            if (KeyData == (Keys.Escape))
            {
                Close();
                Return = false;
                return true;
            }

            return base.ProcessCmdKey(ref msg, KeyData);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==(char)Keys.Enter)
                btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Enter quantity to return", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantity.Focus();
                Return = false;
               
            }
            else if (int.Parse(txtQuantity.Text) <= 0)
            {
                MessageBox.Show("Quantity cannot be zero(0) or negative (-)", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantity.Focus();
                Return = false;
            }
            else
            {
                Qty = int.Parse(txtQuantity.Text);
                if (Qty > SoldQty)
                {
                    MessageBox.Show("Quantity to return can't exceed quantity sold", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Qty = 0;
                    Return = false;
                }
                else
                {
                    Return = true;
                    this.Close();
                }
            }
        }
    }
}
