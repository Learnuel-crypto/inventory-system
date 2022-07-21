namespace Inventory_System.API.Sales_mgt
{
    partial class ReturnPurchaseFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnPurchaseFrm));
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.dgvSoldItems = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.btnReturnSale = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnReturnall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldItems)).BeginInit();
            this.SuspendLayout();
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
            this.dgvStock.Location = new System.Drawing.Point(3, 31);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.Size = new System.Drawing.Size(784, 62);
            this.dgvStock.TabIndex = 192;
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
            this.dgvSoldItems.Location = new System.Drawing.Point(0, 128);
            this.dgvSoldItems.Name = "dgvSoldItems";
            this.dgvSoldItems.ReadOnly = true;
            this.dgvSoldItems.RowHeadersWidth = 20;
            this.dgvSoldItems.Size = new System.Drawing.Size(790, 331);
            this.dgvSoldItems.TabIndex = 193;
            this.dgvSoldItems.Click += new System.EventHandler(this.dgvSoldItems_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(-1, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 196;
            this.label5.Text = "Products";
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceID.ForeColor = System.Drawing.Color.Teal;
            this.lblInvoiceID.Location = new System.Drawing.Point(274, 9);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(132, 19);
            this.lblInvoiceID.TabIndex = 197;
            this.lblInvoiceID.Text = "Return Purchase";
            // 
            // btnReturnSale
            // 
            this.btnReturnSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnSale.FlatAppearance.BorderSize = 0;
            this.btnReturnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnSale.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnReturnSale.Image = global::Inventory_System.Properties.Resources.Return_Purchase_24px_11;
            this.btnReturnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnSale.Location = new System.Drawing.Point(697, 97);
            this.btnReturnSale.Name = "btnReturnSale";
            this.btnReturnSale.Size = new System.Drawing.Size(81, 27);
            this.btnReturnSale.TabIndex = 198;
            this.btnReturnSale.Text = "Return";
            this.btnReturnSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnReturnSale, "Return purchase");
            this.btnReturnSale.UseVisualStyleBackColor = true;
            this.btnReturnSale.Click += new System.EventHandler(this.btnReturnSale_Click);
            // 
            // btnReturnall
            // 
            this.btnReturnall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnall.FlatAppearance.BorderSize = 0;
            this.btnReturnall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnall.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnReturnall.Image = global::Inventory_System.Properties.Resources.Return_Purchase_24px_11;
            this.btnReturnall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnall.Location = new System.Drawing.Point(587, 100);
            this.btnReturnall.Name = "btnReturnall";
            this.btnReturnall.Size = new System.Drawing.Size(104, 27);
            this.btnReturnall.TabIndex = 199;
            this.btnReturnall.Text = "Return all";
            this.btnReturnall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnReturnall, "Return purchase");
            this.btnReturnall.UseVisualStyleBackColor = true;
            this.btnReturnall.Click += new System.EventHandler(this.btnReturnall_Click);
            // 
            // ReturnPurchaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 459);
            this.Controls.Add(this.btnReturnall);
            this.Controls.Add(this.btnReturnSale);
            this.Controls.Add(this.lblInvoiceID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvSoldItems);
            this.Controls.Add(this.dgvStock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReturnPurchaseFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return purchase";
            this.Load += new System.EventHandler(this.ReturnPurchaseFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridView dgvSoldItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.Button btnReturnSale;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnReturnall;
    }
}