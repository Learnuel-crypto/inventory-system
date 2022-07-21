namespace Inventory_System.API.Sales_mgt
{
    partial class ItemsViewFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsViewFrm));
            this.dgvSoldItems = new System.Windows.Forms.DataGridView();
            this.linkPrintStock = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSoldItems
            // 
            this.dgvSoldItems.AllowUserToAddRows = false;
            this.dgvSoldItems.AllowUserToDeleteRows = false;
            this.dgvSoldItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoldItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSoldItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSoldItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoldItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSoldItems.Location = new System.Drawing.Point(0, 33);
            this.dgvSoldItems.Name = "dgvSoldItems";
            this.dgvSoldItems.ReadOnly = true;
            this.dgvSoldItems.RowHeadersWidth = 20;
            this.dgvSoldItems.Size = new System.Drawing.Size(562, 354);
            this.dgvSoldItems.TabIndex = 192;
            // 
            // linkPrintStock
            // 
            this.linkPrintStock.AutoSize = true;
            this.linkPrintStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkPrintStock.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linkPrintStock.Image = global::Inventory_System.Properties.Resources.Print_20px;
            this.linkPrintStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkPrintStock.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkPrintStock.Location = new System.Drawing.Point(496, 9);
            this.linkPrintStock.Name = "linkPrintStock";
            this.linkPrintStock.Size = new System.Drawing.Size(54, 19);
            this.linkPrintStock.TabIndex = 194;
            this.linkPrintStock.TabStop = true;
            this.linkPrintStock.Text = "    Print";
            this.linkPrintStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkPrintStock.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPrintStock_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 195;
            this.label5.Text = "Invoice ID:";
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceID.Location = new System.Drawing.Point(104, 9);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(49, 19);
            this.lblInvoiceID.TabIndex = 196;
            this.lblInvoiceID.Text = "none";
            // 
            // ItemsViewFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 387);
            this.Controls.Add(this.lblInvoiceID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkPrintStock);
            this.Controls.Add(this.dgvSoldItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ItemsViewFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sale Invoice Details";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ItemsViewFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSoldItems;
        private System.Windows.Forms.LinkLabel linkPrintStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInvoiceID;
    }
}