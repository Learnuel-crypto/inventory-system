namespace Inventory_System.API.Sales_mgt
{
    partial class ReturneditemsMgtFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturneditemsMgtFrm));
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkPrintStock = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.linkrefresh = new System.Windows.Forms.LinkLabel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(3, 89);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.Size = new System.Drawing.Size(663, 427);
            this.dgvItems.TabIndex = 192;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkPrintStock);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.linkrefresh);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 84);
            this.groupBox1.TabIndex = 193;
            this.groupBox1.TabStop = false;
            // 
            // linkPrintStock
            // 
            this.linkPrintStock.AutoSize = true;
            this.linkPrintStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkPrintStock.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linkPrintStock.Image = global::Inventory_System.Properties.Resources.Print_20px;
            this.linkPrintStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkPrintStock.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkPrintStock.Location = new System.Drawing.Point(433, 53);
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
            this.label12.Location = new System.Drawing.Point(15, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 21);
            this.label12.TabIndex = 192;
            this.label12.Text = "From";
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(228, 46);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(115, 26);
            this.dtpTo.TabIndex = 190;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(67, 44);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(118, 26);
            this.dtpFrom.TabIndex = 189;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(195, 48);
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
            this.linkrefresh.Location = new System.Drawing.Point(351, 52);
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
            this.txtSearch.Size = new System.Drawing.Size(415, 27);
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
            // ReturneditemsMgtFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(669, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReturneditemsMgtFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Returned items";
            this.Load += new System.EventHandler(this.ReturneditemsMgtFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkPrintStock;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkrefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
    }
}