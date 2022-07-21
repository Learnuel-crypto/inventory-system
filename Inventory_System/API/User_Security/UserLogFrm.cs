using System;
using System.Windows.Forms;
using Inventory_System.Model;
using Inventory_System.Model.Helper;
using Inventory_System.API.Notification;

namespace Inventory_System.API.User_Security
{
    public partial class UserLogFrm : Form
    {
        private UserActivity activity = Factory.CreateActivity();
        public UserLogFrm()
        {
            InitializeComponent();
        }

        private void UserLogFrm_Load(object sender, EventArgs e)
        {
            DataGridStyle.StyleDatagridview(dgvLogs);
            dgvLogs.DataSource = activity.DisplayUserLog("");
            dgvLogs.Columns[0].Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvLogs.DataSource = activity.DisplayUserLog(txtSearch.Text.Trim());
        }

        private void linkRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvLogs.DataSource = activity.DisplayUserLog("");
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            dgvLogs.DataSource = activity.SearchByDate(dtpFrom.Value);
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            dgvLogs.DataSource = activity.SearchBetweenDates(dtpFrom.Value, dtpTo.Value);
        }

        private void linkPrintStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var print = new PrinterNotificationFrm();
            print.ShowDialog();
            if (MyPrinter.Print == true)
                MyPrinter.PrintRecordsPortrate(dgvLogs, MyPrinter.printTitle);

        }
    }
}
