namespace Inventory_System.API
{
    partial class DashboardFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbluName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblurole = new System.Windows.Forms.Label();
            this.lbluid = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LoginTimer = new System.Windows.Forms.Timer(this.components);
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.addNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnedSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.customersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem1,
            this.viewToolStripMenuItem,
            this.userLogsToolStripMenuItem,
            this.resetLoginToolStripMenuItem,
            this.setReceiptToolStripMenuItem});
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(53, 25);
            this.registerToolStripMenuItem.Text = "Staff";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeSaleToolStripMenuItem,
            this.viewSalesToolStripMenuItem,
            this.returnedSalesToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem1});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(97, 25);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(114, 26);
            this.viewToolStripMenuItem1.Text = "View";
            this.viewToolStripMenuItem1.Click += new System.EventHandler(this.viewToolStripMenuItem1_Click);
            // 
            // lbluName
            // 
            this.lbluName.AutoSize = true;
            this.lbluName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluName.Location = new System.Drawing.Point(11, 45);
            this.lbluName.Name = "lbluName";
            this.lbluName.Size = new System.Drawing.Size(124, 18);
            this.lbluName.TabIndex = 1;
            this.lbluName.Text = "Login UserName:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(60, 9);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(75, 18);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "UserRole:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(28, 27);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(107, 18);
            this.lblUserID.TabIndex = 3;
            this.lblUserID.Text = "LoggedUserID:";
            // 
            // lblurole
            // 
            this.lblurole.AutoSize = true;
            this.lblurole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblurole.Location = new System.Drawing.Point(141, 9);
            this.lblurole.Name = "lblurole";
            this.lblurole.Size = new System.Drawing.Size(71, 18);
            this.lblurole.TabIndex = 5;
            this.lblurole.Text = "UserRole";
            // 
            // lbluid
            // 
            this.lbluid.AutoSize = true;
            this.lbluid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluid.Location = new System.Drawing.Point(141, 27);
            this.lbluid.Name = "lbluid";
            this.lbluid.Size = new System.Drawing.Size(103, 18);
            this.lbluid.TabIndex = 6;
            this.lbluid.Text = "LoggedUserID";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(141, 45);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(120, 18);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Login UserName";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(160, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 106);
            this.label1.TabIndex = 7;
            this.label1.Text = "M.M Traders";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbluid);
            this.panel1.Controls.Add(this.lbluName);
            this.panel1.Controls.Add(this.lblurole);
            this.panel1.Controls.Add(this.lblUserID);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Location = new System.Drawing.Point(501, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 71);
            this.panel1.TabIndex = 172;
            // 
            // LoginTimer
            // 
            this.LoginTimer.Interval = 20000;
            this.LoginTimer.Tick += new System.EventHandler(this.LoginTimer_Tick);
            // 
            // picLogout
            // 
            this.picLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogout.Image = global::Inventory_System.Properties.Resources.Logout_Rounded_48px;
            this.picLogout.Location = new System.Drawing.Point(746, 32);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(38, 31);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogout.TabIndex = 174;
            this.picLogout.TabStop = false;
            this.toolTip1.SetToolTip(this.picLogout, "Logout");
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // picExit
            // 
            this.picExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = global::Inventory_System.Properties.Resources.Shutdown_48px;
            this.picExit.Location = new System.Drawing.Point(702, 32);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(38, 31);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 173;
            this.picExit.TabStop = false;
            this.toolTip1.SetToolTip(this.picExit, "Shutdown Application");
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // addNewToolStripMenuItem1
            // 
            this.addNewToolStripMenuItem1.Image = global::Inventory_System.Properties.Resources.add_24px;
            this.addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
            this.addNewToolStripMenuItem1.Size = new System.Drawing.Size(157, 26);
            this.addNewToolStripMenuItem1.Text = "Add new";
            this.addNewToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewToolStripMenuItem1.Click += new System.EventHandler(this.addNewToolStripMenuItem1_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Image = global::Inventory_System.Properties.Resources.Visible_20px;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.viewToolStripMenuItem.Text = "View staff";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // userLogsToolStripMenuItem
            // 
            this.userLogsToolStripMenuItem.Image = global::Inventory_System.Properties.Resources.Activity_Grid_2_24px;
            this.userLogsToolStripMenuItem.Name = "userLogsToolStripMenuItem";
            this.userLogsToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.userLogsToolStripMenuItem.Text = "User logs";
            this.userLogsToolStripMenuItem.Click += new System.EventHandler(this.userLogsToolStripMenuItem_Click);
            // 
            // resetLoginToolStripMenuItem
            // 
            this.resetLoginToolStripMenuItem.Image = global::Inventory_System.Properties.Resources.User_Credentials_24px;
            this.resetLoginToolStripMenuItem.Name = "resetLoginToolStripMenuItem";
            this.resetLoginToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.resetLoginToolStripMenuItem.Text = "Reset login";
            this.resetLoginToolStripMenuItem.Click += new System.EventHandler(this.resetLoginToolStripMenuItem_Click);
            // 
            // setReceiptToolStripMenuItem
            // 
            this.setReceiptToolStripMenuItem.Image = global::Inventory_System.Properties.Resources.Purchase_Order_24px;
            this.setReceiptToolStripMenuItem.Name = "setReceiptToolStripMenuItem";
            this.setReceiptToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.setReceiptToolStripMenuItem.Text = "Set receipt";
            this.setReceiptToolStripMenuItem.Click += new System.EventHandler(this.setReceiptToolStripMenuItem_Click);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.addNewToolStripMenuItem.Image = global::Inventory_System.Properties.Resources.add_24px;
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.addNewToolStripMenuItem.Text = "Add new";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Image = global::Inventory_System.Properties.Resources.Sell_Stock_24px;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // makeSaleToolStripMenuItem
            // 
            this.makeSaleToolStripMenuItem.Image = global::Inventory_System.Properties.Resources.add_24px;
            this.makeSaleToolStripMenuItem.Name = "makeSaleToolStripMenuItem";
            this.makeSaleToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.makeSaleToolStripMenuItem.Text = "Make sale";
            this.makeSaleToolStripMenuItem.Click += new System.EventHandler(this.makeSaleToolStripMenuItem_Click);
            // 
            // viewSalesToolStripMenuItem
            // 
            this.viewSalesToolStripMenuItem.Image = global::Inventory_System.Properties.Resources.Visible_20px;
            this.viewSalesToolStripMenuItem.Name = "viewSalesToolStripMenuItem";
            this.viewSalesToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.viewSalesToolStripMenuItem.Text = "View sales";
            this.viewSalesToolStripMenuItem.Click += new System.EventHandler(this.viewSalesToolStripMenuItem_Click);
            // 
            // returnedSalesToolStripMenuItem
            // 
            this.returnedSalesToolStripMenuItem.Image = global::Inventory_System.Properties.Resources.Return_Purchase_24px_11;
            this.returnedSalesToolStripMenuItem.Name = "returnedSalesToolStripMenuItem";
            this.returnedSalesToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.returnedSalesToolStripMenuItem.Text = "Returned sales";
            this.returnedSalesToolStripMenuItem.Click += new System.EventHandler(this.returnedSalesToolStripMenuItem_Click);
            // 
            // DashboardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 453);
            this.Controls.Add(this.picLogout);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardFrm_FormClosing);
            this.Load += new System.EventHandler(this.DashboardFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem1;
        private System.Windows.Forms.Label lbluName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblurole;
        private System.Windows.Forms.Label lbluid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSalesToolStripMenuItem;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userLogsToolStripMenuItem;
        private System.Windows.Forms.Timer LoginTimer;
        private System.Windows.Forms.ToolStripMenuItem resetLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnedSalesToolStripMenuItem;
    }
}