namespace Inventory_System.API.Sales_mgt
{
    partial class SalesInformationFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesInformationFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkReturneditems = new System.Windows.Forms.LinkLabel();
            this.linkReturnItems = new System.Windows.Forms.LinkLabel();
            this.linkViewCustomer = new System.Windows.Forms.LinkLabel();
            this.linkViewItems = new System.Windows.Forms.LinkLabel();
            this.linkGenReport = new System.Windows.Forms.LinkLabel();
            this.linkPrintStock = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.linkrefresh = new System.Windows.Forms.LinkLabel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbCheque = new System.Windows.Forms.RadioButton();
            this.rbReturned = new System.Windows.Forms.RadioButton();
            this.rbToday = new System.Windows.Forms.RadioButton();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.linkReturneditems);
            this.groupBox1.Controls.Add(this.linkReturnItems);
            this.groupBox1.Controls.Add(this.linkViewCustomer);
            this.groupBox1.Controls.Add(this.linkViewItems);
            this.groupBox1.Controls.Add(this.linkGenReport);
            this.groupBox1.Controls.Add(this.linkPrintStock);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.linkrefresh);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(213, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 98);
            this.groupBox1.TabIndex = 187;
            this.groupBox1.TabStop = false;
            // 
            // linkReturneditems
            // 
            this.linkReturneditems.AutoSize = true;
            this.linkReturneditems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkReturneditems.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.linkReturneditems.Image = global::Inventory_System.Properties.Resources.Visible_20px;
            this.linkReturneditems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkReturneditems.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkReturneditems.Location = new System.Drawing.Point(125, 72);
            this.linkReturneditems.Name = "linkReturneditems";
            this.linkReturneditems.Size = new System.Drawing.Size(132, 19);
            this.linkReturneditems.TabIndex = 199;
            this.linkReturneditems.TabStop = true;
            this.linkReturneditems.Text = "     Returned items";
            this.toolTip1.SetToolTip(this.linkReturneditems, "view returned items");
            this.linkReturneditems.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReturneditems_LinkClicked);
            // 
            // linkReturnItems
            // 
            this.linkReturnItems.AutoSize = true;
            this.linkReturnItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkReturnItems.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linkReturnItems.Image = global::Inventory_System.Properties.Resources.Return_Purchase_24px_11;
            this.linkReturnItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkReturnItems.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkReturnItems.Location = new System.Drawing.Point(6, 73);
            this.linkReturnItems.Name = "linkReturnItems";
            this.linkReturnItems.Size = new System.Drawing.Size(113, 19);
            this.linkReturnItems.TabIndex = 190;
            this.linkReturnItems.TabStop = true;
            this.linkReturnItems.Text = "     Return items";
            this.toolTip1.SetToolTip(this.linkReturnItems, "Return sold items");
            this.linkReturnItems.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReturnItems_LinkClicked);
            // 
            // linkViewCustomer
            // 
            this.linkViewCustomer.AutoSize = true;
            this.linkViewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkViewCustomer.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.linkViewCustomer.Image = global::Inventory_System.Properties.Resources.Visible_20px;
            this.linkViewCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkViewCustomer.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkViewCustomer.Location = new System.Drawing.Point(76, 48);
            this.linkViewCustomer.Name = "linkViewCustomer";
            this.linkViewCustomer.Size = new System.Drawing.Size(67, 19);
            this.linkViewCustomer.TabIndex = 198;
            this.linkViewCustomer.TabStop = true;
            this.linkViewCustomer.Text = "     Buyer";
            this.toolTip1.SetToolTip(this.linkViewCustomer, "view customer sold to");
            this.linkViewCustomer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkViewCustomer_LinkClicked);
            // 
            // linkViewItems
            // 
            this.linkViewItems.AutoSize = true;
            this.linkViewItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkViewItems.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.linkViewItems.Image = global::Inventory_System.Properties.Resources.Visible_20px;
            this.linkViewItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkViewItems.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkViewItems.Location = new System.Drawing.Point(6, 47);
            this.linkViewItems.Name = "linkViewItems";
            this.linkViewItems.Size = new System.Drawing.Size(64, 19);
            this.linkViewItems.TabIndex = 197;
            this.linkViewItems.TabStop = true;
            this.linkViewItems.Text = "     Items";
            this.toolTip1.SetToolTip(this.linkViewItems, "view items sold");
            this.linkViewItems.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkViewItems_LinkClicked);
            // 
            // linkGenReport
            // 
            this.linkGenReport.AutoSize = true;
            this.linkGenReport.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linkGenReport.Image = global::Inventory_System.Properties.Resources.Print_20px;
            this.linkGenReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkGenReport.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkGenReport.Location = new System.Drawing.Point(445, 74);
            this.linkGenReport.Name = "linkGenReport";
            this.linkGenReport.Size = new System.Drawing.Size(137, 19);
            this.linkGenReport.TabIndex = 194;
            this.linkGenReport.TabStop = true;
            this.linkGenReport.Text = "    Generate report";
            this.linkGenReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGenReport_LinkClicked);
            // 
            // linkPrintStock
            // 
            this.linkPrintStock.AutoSize = true;
            this.linkPrintStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkPrintStock.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linkPrintStock.Image = global::Inventory_System.Properties.Resources.Print_20px;
            this.linkPrintStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkPrintStock.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkPrintStock.Location = new System.Drawing.Point(380, 74);
            this.linkPrintStock.Name = "linkPrintStock";
            this.linkPrintStock.Size = new System.Drawing.Size(54, 19);
            this.linkPrintStock.TabIndex = 193;
            this.linkPrintStock.TabStop = true;
            this.linkPrintStock.Text = "    Print";
            this.linkPrintStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkPrintStock.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPrintStock_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label12.Location = new System.Drawing.Point(413, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 21);
            this.label12.TabIndex = 192;
            this.label12.Text = "From";
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(468, 44);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(115, 26);
            this.dtpTo.TabIndex = 190;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(465, 12);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(118, 26);
            this.dtpFrom.TabIndex = 189;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(435, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 21);
            this.label6.TabIndex = 191;
            this.label6.Text = "To";
            // 
            // linkrefresh
            // 
            this.linkrefresh.AutoSize = true;
            this.linkrefresh.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linkrefresh.Image = global::Inventory_System.Properties.Resources.Replace_20px;
            this.linkrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkrefresh.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkrefresh.Location = new System.Drawing.Point(294, 74);
            this.linkrefresh.Name = "linkrefresh";
            this.linkrefresh.Size = new System.Drawing.Size(74, 19);
            this.linkrefresh.TabIndex = 188;
            this.linkrefresh.TabStop = true;
            this.linkrefresh.Text = "    Refresh";
            this.linkrefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkrefresh_LinkClicked);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(72, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(335, 27);
            this.txtSearch.TabIndex = 187;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(2, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 186;
            this.label3.Text = "Search";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rbCheque);
            this.groupBox3.Controls.Add(this.rbReturned);
            this.groupBox3.Controls.Add(this.rbToday);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox3.Location = new System.Drawing.Point(3, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 86);
            this.groupBox3.TabIndex = 190;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View ";
            // 
            // rbCheque
            // 
            this.rbCheque.AutoSize = true;
            this.rbCheque.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.rbCheque.Location = new System.Drawing.Point(9, 50);
            this.rbCheque.Name = "rbCheque";
            this.rbCheque.Size = new System.Drawing.Size(84, 23);
            this.rbCheque.TabIndex = 2;
            this.rbCheque.TabStop = true;
            this.rbCheque.Text = "Cheque";
            this.rbCheque.UseVisualStyleBackColor = true;
            this.rbCheque.CheckedChanged += new System.EventHandler(this.rbCheque_CheckedChanged);
            // 
            // rbReturned
            // 
            this.rbReturned.AutoSize = true;
            this.rbReturned.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.rbReturned.Location = new System.Drawing.Point(88, 19);
            this.rbReturned.Name = "rbReturned";
            this.rbReturned.Size = new System.Drawing.Size(95, 23);
            this.rbReturned.TabIndex = 1;
            this.rbReturned.TabStop = true;
            this.rbReturned.Text = "Returned ";
            this.rbReturned.UseVisualStyleBackColor = true;
            this.rbReturned.CheckedChanged += new System.EventHandler(this.rbReturned_CheckedChanged);
            // 
            // rbToday
            // 
            this.rbToday.AutoSize = true;
            this.rbToday.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.rbToday.Location = new System.Drawing.Point(9, 19);
            this.rbToday.Name = "rbToday";
            this.rbToday.Size = new System.Drawing.Size(73, 23);
            this.rbToday.TabIndex = 0;
            this.rbToday.TabStop = true;
            this.rbToday.Text = "Today ";
            this.rbToday.UseVisualStyleBackColor = true;
            this.rbToday.CheckedChanged += new System.EventHandler(this.rbToday_CheckedChanged);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(3, 105);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.Size = new System.Drawing.Size(801, 415);
            this.dgvStock.TabIndex = 191;
            this.dgvStock.Click += new System.EventHandler(this.dgvStock_Click);
            this.dgvStock.DoubleClick += new System.EventHandler(this.dgvStock_DoubleClick);
            // 
            // SalesInformationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 522);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesInformationFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Information";
            this.Load += new System.EventHandler(this.SalesInformationFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkrefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkPrintStock;
        private System.Windows.Forms.LinkLabel linkGenReport;
        private System.Windows.Forms.RadioButton rbCheque;
        private System.Windows.Forms.RadioButton rbReturned;
        private System.Windows.Forms.RadioButton rbToday;
        private System.Windows.Forms.LinkLabel linkViewCustomer;
        private System.Windows.Forms.LinkLabel linkViewItems;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkReturnItems;
        private System.Windows.Forms.LinkLabel linkReturneditems;
    }
}