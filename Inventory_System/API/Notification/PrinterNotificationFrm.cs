 
using Inventory_System.Model;
using System;
using System.Windows.Forms;

namespace Inventory_System.API.Notification
{
    public partial class PrinterNotificationFrm : Form
    {
        public PrinterNotificationFrm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtprintTitle.Text))
            {
                if (MessageBox.Show("Page heading is empty, Continue print", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    MyPrinter.Print = true;
                    MyPrinter.printTitle = txtprintTitle.Text;
                    this.Close();
                }
            }
            else
            {
                MyPrinter.Print = true;
                MyPrinter.printTitle = txtprintTitle.Text;
                this.Close();
            }
            ActiveControl = txtprintTitle;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MyPrinter.Print = false;
            this.Close();
        }

        private void txtprintTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnOk.PerformClick();
            }
        }
    }
}
