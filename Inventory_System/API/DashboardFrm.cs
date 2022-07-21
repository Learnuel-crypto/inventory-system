using System;
using System.Windows.Forms;
using Inventory_System.Model;
using Inventory_System.API.Sales_mgt;
using Inventory_System.Model.Helper;
using Inventory_System.API.Customers;
using Inventory_System.API.User_Security;

namespace Inventory_System.API
{
    public partial class DashboardFrm : Form
    {
        ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
        private IUsers user = Factory.CreateUser();
        public DashboardFrm()
        {
            InitializeComponent();
        }

        private void DashboardFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var register = new RegistrationFrm(Users.RoleID);
                register.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "User error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        private void DashboardFrm_Load(object sender, EventArgs e)
        {
            try {  
            lbluid.Text=Users.LoggedUserID;
            lblname.Text = Users.LoggedUsername;
            lblurole.Text = Users.Role;
            LoginTimer.Start();
            MyPrinter.GetReceiptDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            try
            {
                var staff = new StaffFrm(Users.RoleID);
                staff.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "User error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new ProductRegistrationFrm(Users.RoleID);
                product.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "User error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
               
                var stock = new StockManagementFrm(Users.RoleID);
                stock.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "User error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void makeSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                 
                var sales = new SalesFrm(Users.RoleID);
                sales.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "User error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            try
            {

                var salesView = new SalesInformationFrm(Users.RoleID);
                salesView.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "User error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            UserActivity.RecordActivity("Application shutdown");
            Application.Exit();
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            var logout = new LoginFrm();
            this.Hide();
            UserActivity.RecordActivity("Logout");
            logout.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            { 
                var customerView = new CustomerManagementFrm(Users.RoleID);
                customerView.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "User error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userLogsToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            try
            {
                var logView = new UserLogFrm();
                logView.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "User error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoginTimer_Tick(object sender, EventArgs e)
        {
            //if (Users.IsLoggedIn == false)
            //{
            //    var logoutFrm = new LogoutFrm();
            //    LoginTimer.Stop();
            //    logoutFrm.ShowDialog();
            //    LoginTimer.Start();
            //}
        }

        private void resetLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var resetLogin = new ResetLoginFrm();
                resetLogin.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "User error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void setReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            try
            {
                var setReceiptrm = new SetReceiptrm(Users.RoleID);
                setReceiptrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "User error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void returnedSalesToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            try
            {
                var returnedItems = new ReturneditemsMgtFrm();
                returnedItems.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "User error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
