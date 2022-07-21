namespace Inventory_System.API.User_Security
{
    partial class UserLogFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogFrm));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkRefresh = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.linkPrintStock = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(69, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(295, 27);
            this.txtSearch.TabIndex = 189;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 188;
            this.label3.Text = "Search";
            // 
            // linkRefresh
            // 
            this.linkRefresh.AutoSize = true;
            this.linkRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkRefresh.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linkRefresh.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkRefresh.Location = new System.Drawing.Point(352, 51);
            this.linkRefresh.Name = "linkRefresh";
            this.linkRefresh.Size = new System.Drawing.Size(58, 19);
            this.linkRefresh.TabIndex = 194;
            this.linkRefresh.TabStop = true;
            this.linkRefresh.Text = "Refresh";
            this.linkRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRefresh_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label12.Location = new System.Drawing.Point(13, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 21);
            this.label12.TabIndex = 193;
            this.label12.Text = "From";
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(231, 45);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(115, 26);
            this.dtpTo.TabIndex = 191;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(65, 45);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(118, 26);
            this.dtpFrom.TabIndex = 190;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(198, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 21);
            this.label6.TabIndex = 192;
            this.label6.Text = "To";
            // 
            // dgvLogs
            // 
            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.AllowUserToDeleteRows = false;
            this.dgvLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Location = new System.Drawing.Point(1, 77);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.ReadOnly = true;
            this.dgvLogs.Size = new System.Drawing.Size(460, 382);
            this.dgvLogs.TabIndex = 195;
            // 
            // linkPrintStock
            // 
            this.linkPrintStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkPrintStock.AutoSize = true;
            this.linkPrintStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkPrintStock.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linkPrintStock.Image = global::Inventory_System.Properties.Resources.Print_20px;
            this.linkPrintStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkPrintStock.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkPrintStock.Location = new System.Drawing.Point(393, 13);
            this.linkPrintStock.Name = "linkPrintStock";
            this.linkPrintStock.Size = new System.Drawing.Size(54, 19);
            this.linkPrintStock.TabIndex = 196;
            this.linkPrintStock.TabStop = true;
            this.linkPrintStock.Text = "    Print";
            this.linkPrintStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkPrintStock.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPrintStock_LinkClicked);
            // 
            // UserLogFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 458);
            this.Controls.Add(this.linkPrintStock);
            this.Controls.Add(this.dgvLogs);
            this.Controls.Add(this.linkRefresh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserLogFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User logs";
            this.Load += new System.EventHandler(this.UserLogFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkRefresh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.LinkLabel linkPrintStock;
    }
}