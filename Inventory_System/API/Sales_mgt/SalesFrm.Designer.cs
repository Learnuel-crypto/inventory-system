namespace Inventory_System.API
{
    partial class SalesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesFrm));
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.combBrand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.txtItemDiscount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.combPayment = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkrefresh = new System.Windows.Forms.LinkLabel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCashAtHand = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkReturnItems = new System.Windows.Forms.LinkLabel();
            this.btnReturnedSales = new System.Windows.Forms.Button();
            this.btnCheque = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.panCusomter = new System.Windows.Forms.Panel();
            this.dtpCheque = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblCloseCustomerPan = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSearchCustomers = new System.Windows.Forms.TextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.BillTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panCashCustomer = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblCloseCashPan = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panCusomter.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.panCashCustomer.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(3, 27);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.Size = new System.Drawing.Size(447, 421);
            this.dgvStock.TabIndex = 1;
            this.dgvStock.Click += new System.EventHandler(this.dgvStock_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.dgvStock);
            this.panel1.Location = new System.Drawing.Point(566, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 451);
            this.panel1.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(453, 19);
            this.panel6.TabIndex = 190;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Available stock";
            // 
            // combBrand
            // 
            this.combBrand.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.combBrand.FormattingEnabled = true;
            this.combBrand.Location = new System.Drawing.Point(198, 42);
            this.combBrand.Name = "combBrand";
            this.combBrand.Size = new System.Drawing.Size(254, 25);
            this.combBrand.TabIndex = 177;
            this.combBrand.SelectedIndexChanged += new System.EventHandler(this.combBrand_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(137, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 178;
            this.label4.Text = "Brend";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.dgvCart);
            this.panel2.Location = new System.Drawing.Point(4, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 455);
            this.panel2.TabIndex = 179;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.label12);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(344, 19);
            this.panel5.TabIndex = 190;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, -1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 19);
            this.label12.TabIndex = 28;
            this.label12.Text = "Cart items";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnRemove.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnRemove.Image = global::Inventory_System.Properties.Resources.Cancel_20px;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(252, 422);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 29);
            this.btnRemove.TabIndex = 186;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnRemove, "Remove stock from cart");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(3, 25);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.Size = new System.Drawing.Size(338, 393);
            this.dgvCart.TabIndex = 27;
            this.dgvCart.Click += new System.EventHandler(this.dgvCart_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.txtItemDiscount);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnSell);
            this.panel3.Controls.Add(this.lblBalance);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.txtAmount);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.lblNetPay);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.txtDiscount);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.combPayment);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.btnAddToCart);
            this.panel3.Controls.Add(this.lblSellingPrice);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.lblDescription);
            this.panel3.Controls.Add(this.txtQuantity);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(351, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 439);
            this.panel3.TabIndex = 180;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label22.Location = new System.Drawing.Point(5, 123);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 17);
            this.label22.TabIndex = 207;
            this.label22.Text = "Discout %";
            // 
            // txtItemDiscount
            // 
            this.txtItemDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemDiscount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemDiscount.Location = new System.Drawing.Point(5, 144);
            this.txtItemDiscount.Name = "txtItemDiscount";
            this.txtItemDiscount.Size = new System.Drawing.Size(80, 27);
            this.txtItemDiscount.TabIndex = 208;
            this.toolTip1.SetToolTip(this.txtItemDiscount, "Stock discount");
            this.txtItemDiscount.TextChanged += new System.EventHandler(this.txtItemDiscount_TextChanged);
            this.txtItemDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemDiscount_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(188, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 19);
            this.label8.TabIndex = 191;
            this.label8.Text = "%";
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.White;
            this.btnSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSell.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnSell.Image = global::Inventory_System.Properties.Resources.Buy_24px;
            this.btnSell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSell.Location = new System.Drawing.Point(123, 402);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(82, 27);
            this.btnSell.TabIndex = 206;
            this.btnSell.Text = "Sell";
            this.btnSell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSell, "Sell items");
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Cambria", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblBalance.Location = new System.Drawing.Point(91, 372);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(38, 17);
            this.lblBalance.TabIndex = 205;
            this.lblBalance.Text = "0.00";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.label20.Location = new System.Drawing.Point(16, 370);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 20);
            this.label20.TabIndex = 204;
            this.label20.Text = "Balance:";
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(89, 338);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(116, 27);
            this.txtAmount.TabIndex = 203;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.label15.Location = new System.Drawing.Point(14, 341);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 20);
            this.label15.TabIndex = 202;
            this.label15.Text = "Amount:";
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Font = new System.Drawing.Font("Cambria", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblNetPay.Location = new System.Drawing.Point(88, 313);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(38, 17);
            this.lblNetPay.TabIndex = 201;
            this.lblNetPay.Text = "0.00";
            this.lblNetPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.label19.Location = new System.Drawing.Point(14, 310);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 20);
            this.label19.TabIndex = 200;
            this.label19.Text = "Net Pay:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(89, 277);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(92, 27);
            this.txtDiscount.TabIndex = 199;
            this.toolTip1.SetToolTip(this.txtDiscount, "bill discount");
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.label17.Location = new System.Drawing.Point(8, 280);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 20);
            this.label17.TabIndex = 198;
            this.label17.Text = "Discount:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Cambria", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(90, 256);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 17);
            this.lblTotal.TabIndex = 197;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.label16.Location = new System.Drawing.Point(1, 254);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 20);
            this.label16.TabIndex = 196;
            this.label16.Text = "Total cost:";
            // 
            // combPayment
            // 
            this.combPayment.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.combPayment.FormattingEnabled = true;
            this.combPayment.Items.AddRange(new object[] {
            "Cash",
            "Cheque"});
            this.combPayment.Location = new System.Drawing.Point(9, 222);
            this.combPayment.Name = "combPayment";
            this.combPayment.Size = new System.Drawing.Size(160, 25);
            this.combPayment.TabIndex = 191;
            this.combPayment.SelectedIndexChanged += new System.EventHandler(this.combPayment_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label14.Location = new System.Drawing.Point(5, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 19);
            this.label14.TabIndex = 195;
            this.label14.Text = "Payment type";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel7.Controls.Add(this.lblBillNo);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label2);
            this.panel7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Location = new System.Drawing.Point(0, 175);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(212, 22);
            this.panel7.TabIndex = 190;
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillNo.ForeColor = System.Drawing.Color.White;
            this.lblBillNo.Location = new System.Drawing.Point(92, 0);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(18, 19);
            this.lblBillNo.TabIndex = 30;
            this.lblBillNo.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(63, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Billing";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAddToCart.Image = global::Inventory_System.Properties.Resources.Sell_Stock_24px;
            this.btnAddToCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddToCart.Location = new System.Drawing.Point(91, 136);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(117, 27);
            this.btnAddToCart.TabIndex = 194;
            this.btnAddToCart.Text = "Add to cart";
            this.btnAddToCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAddToCart, "Add item to cart");
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.lblSellingPrice.Location = new System.Drawing.Point(104, 77);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(39, 20);
            this.lblSellingPrice.TabIndex = 193;
            this.lblSellingPrice.Text = "0.00";
            this.lblSellingPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label13.Location = new System.Drawing.Point(5, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 192;
            this.label13.Text = "Selling price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblDescription.Location = new System.Drawing.Point(11, 47);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(47, 20);
            this.lblDescription.TabIndex = 191;
            this.lblDescription.Text = "none";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(93, 102);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(115, 27);
            this.txtQuantity.TabIndex = 190;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 19);
            this.panel4.TabIndex = 189;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, -1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label11.Location = new System.Drawing.Point(22, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 19);
            this.label11.TabIndex = 188;
            this.label11.Text = "Quanity:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label10.Location = new System.Drawing.Point(5, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 187;
            this.label10.Text = "Description:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.linkrefresh);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddCustomer);
            this.groupBox1.Controls.Add(this.combBrand);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(560, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 74);
            this.groupBox1.TabIndex = 186;
            this.groupBox1.TabStop = false;
            // 
            // linkrefresh
            // 
            this.linkrefresh.AutoSize = true;
            this.linkrefresh.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linkrefresh.Image = global::Inventory_System.Properties.Resources.Replace_20px;
            this.linkrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkrefresh.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkrefresh.Location = new System.Drawing.Point(50, 51);
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
            this.txtSearch.Location = new System.Drawing.Point(198, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(254, 27);
            this.txtSearch.TabIndex = 187;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(128, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 186;
            this.label3.Text = "Search";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAddCustomer.Image = global::Inventory_System.Properties.Resources.add_24px;
            this.btnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCustomer.Location = new System.Drawing.Point(6, 11);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(102, 27);
            this.btnAddCustomer.TabIndex = 185;
            this.btnAddCustomer.Text = "Customer";
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAddCustomer, "add new customer");
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCashAtHand);
            this.groupBox2.Controls.Add(this.lblTotalSales);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox2.Location = new System.Drawing.Point(301, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 74);
            this.groupBox2.TabIndex = 187;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Day sales";
            // 
            // lblCashAtHand
            // 
            this.lblCashAtHand.AutoSize = true;
            this.lblCashAtHand.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblCashAtHand.Location = new System.Drawing.Point(130, 43);
            this.lblCashAtHand.Name = "lblCashAtHand";
            this.lblCashAtHand.Size = new System.Drawing.Size(37, 19);
            this.lblCashAtHand.TabIndex = 190;
            this.lblCashAtHand.Text = "0.00";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTotalSales.Location = new System.Drawing.Point(12, 44);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(37, 19);
            this.lblTotalSales.TabIndex = 189;
            this.lblTotalSales.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(122, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 188;
            this.label6.Text = "Cash at hand:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(5, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 187;
            this.label5.Text = "Total sales:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkReturnItems);
            this.groupBox3.Controls.Add(this.btnReturnedSales);
            this.groupBox3.Controls.Add(this.btnCheque);
            this.groupBox3.Controls.Add(this.btnSales);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox3.Location = new System.Drawing.Point(8, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 88);
            this.groupBox3.TabIndex = 189;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View sales";
            // 
            // linkReturnItems
            // 
            this.linkReturnItems.AutoSize = true;
            this.linkReturnItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkReturnItems.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linkReturnItems.Image = global::Inventory_System.Properties.Resources.Return_Purchase_24px_11;
            this.linkReturnItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkReturnItems.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkReturnItems.Location = new System.Drawing.Point(170, 66);
            this.linkReturnItems.Name = "linkReturnItems";
            this.linkReturnItems.Size = new System.Drawing.Size(113, 19);
            this.linkReturnItems.TabIndex = 189;
            this.linkReturnItems.TabStop = true;
            this.linkReturnItems.Text = "     Return items";
            this.toolTip1.SetToolTip(this.linkReturnItems, "Return sold items");
            this.linkReturnItems.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReturnItems_LinkClicked);
            // 
            // btnReturnedSales
            // 
            this.btnReturnedSales.FlatAppearance.BorderSize = 0;
            this.btnReturnedSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnedSales.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnReturnedSales.Image = global::Inventory_System.Properties.Resources.Refund_2_24px;
            this.btnReturnedSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnedSales.Location = new System.Drawing.Point(6, 51);
            this.btnReturnedSales.Name = "btnReturnedSales";
            this.btnReturnedSales.Size = new System.Drawing.Size(104, 26);
            this.btnReturnedSales.TabIndex = 188;
            this.btnReturnedSales.Text = "Returned";
            this.btnReturnedSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnReturnedSales, "view returned sales");
            this.btnReturnedSales.UseVisualStyleBackColor = true;
            this.btnReturnedSales.Click += new System.EventHandler(this.btnReturnedSales_Click);
            // 
            // btnCheque
            // 
            this.btnCheque.FlatAppearance.BorderSize = 0;
            this.btnCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheque.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCheque.Image = global::Inventory_System.Properties.Resources.Paycheque_24px;
            this.btnCheque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheque.Location = new System.Drawing.Point(85, 20);
            this.btnCheque.Name = "btnCheque";
            this.btnCheque.Size = new System.Drawing.Size(93, 26);
            this.btnCheque.TabIndex = 187;
            this.btnCheque.Text = "Cheque";
            this.btnCheque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnCheque, "Sales made with cheque");
            this.btnCheque.UseVisualStyleBackColor = true;
            this.btnCheque.Click += new System.EventHandler(this.btnCheque_Click);
            // 
            // btnSales
            // 
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSales.Image = global::Inventory_System.Properties.Resources.Checkout_24px;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(6, 20);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(73, 26);
            this.btnSales.TabIndex = 186;
            this.btnSales.Text = "Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSales, "view today sales");
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // panCusomter
            // 
            this.panCusomter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panCusomter.Controls.Add(this.dtpCheque);
            this.panCusomter.Controls.Add(this.label21);
            this.panCusomter.Controls.Add(this.panel9);
            this.panCusomter.Controls.Add(this.txtSearchCustomers);
            this.panCusomter.Controls.Add(this.dgvCustomers);
            this.panCusomter.Location = new System.Drawing.Point(535, 100);
            this.panCusomter.Name = "panCusomter";
            this.panCusomter.Size = new System.Drawing.Size(281, 425);
            this.panCusomter.TabIndex = 191;
            this.panCusomter.Visible = false;
            // 
            // dtpCheque
            // 
            this.dtpCheque.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dtpCheque.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheque.Location = new System.Drawing.Point(139, 64);
            this.dtpCheque.Name = "dtpCheque";
            this.dtpCheque.Size = new System.Drawing.Size(118, 26);
            this.dtpCheque.TabIndex = 192;
            this.toolTip1.SetToolTip(this.dtpCheque, "Date on cheque");
            this.dtpCheque.ValueChanged += new System.EventHandler(this.dtpCheque_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label21.Location = new System.Drawing.Point(25, 67);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(108, 19);
            this.label21.TabIndex = 191;
            this.label21.Text = "Cheque date:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel9.Controls.Add(this.lblCloseCustomerPan);
            this.panel9.Controls.Add(this.label18);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(281, 19);
            this.panel9.TabIndex = 190;
            // 
            // lblCloseCustomerPan
            // 
            this.lblCloseCustomerPan.AutoSize = true;
            this.lblCloseCustomerPan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseCustomerPan.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCloseCustomerPan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseCustomerPan.ForeColor = System.Drawing.Color.White;
            this.lblCloseCustomerPan.Location = new System.Drawing.Point(261, 0);
            this.lblCloseCustomerPan.Name = "lblCloseCustomerPan";
            this.lblCloseCustomerPan.Size = new System.Drawing.Size(20, 19);
            this.lblCloseCustomerPan.TabIndex = 29;
            this.lblCloseCustomerPan.Text = "X";
            this.toolTip1.SetToolTip(this.lblCloseCustomerPan, "Close");
            this.lblCloseCustomerPan.Click += new System.EventHandler(this.lblCloseCustomerPan_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(3, -1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(130, 19);
            this.label18.TabIndex = 28;
            this.label18.Text = "Select customer";
            // 
            // txtSearchCustomers
            // 
            this.txtSearchCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchCustomers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomers.Location = new System.Drawing.Point(3, 28);
            this.txtSearchCustomers.Name = "txtSearchCustomers";
            this.txtSearchCustomers.Size = new System.Drawing.Size(275, 27);
            this.txtSearchCustomers.TabIndex = 188;
            this.toolTip1.SetToolTip(this.txtSearchCustomers, "Search customer");
            this.txtSearchCustomers.TextChanged += new System.EventHandler(this.txtSearchCustomers_TextChanged);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(3, 96);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidth = 68;
            this.dgvCustomers.Size = new System.Drawing.Size(275, 322);
            this.dgvCustomers.TabIndex = 28;
            this.dgvCustomers.Click += new System.EventHandler(this.dgvCustomers_Click);
            // 
            // BillTimer
            // 
            this.BillTimer.Interval = 1000;
            this.BillTimer.Tick += new System.EventHandler(this.BillTimer_Tick);
            // 
            // panCashCustomer
            // 
            this.panCashCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panCashCustomer.Controls.Add(this.txtCusName);
            this.panCashCustomer.Controls.Add(this.panel8);
            this.panCashCustomer.Location = new System.Drawing.Point(520, 244);
            this.panCashCustomer.Name = "panCashCustomer";
            this.panCashCustomer.Size = new System.Drawing.Size(295, 70);
            this.panCashCustomer.TabIndex = 193;
            this.panCashCustomer.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel8.Controls.Add(this.lblCloseCashPan);
            this.panel8.Controls.Add(this.label24);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(293, 19);
            this.panel8.TabIndex = 191;
            // 
            // lblCloseCashPan
            // 
            this.lblCloseCashPan.AutoSize = true;
            this.lblCloseCashPan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseCashPan.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCloseCashPan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseCashPan.ForeColor = System.Drawing.Color.White;
            this.lblCloseCashPan.Location = new System.Drawing.Point(273, 0);
            this.lblCloseCashPan.Name = "lblCloseCashPan";
            this.lblCloseCashPan.Size = new System.Drawing.Size(20, 19);
            this.lblCloseCashPan.TabIndex = 29;
            this.lblCloseCashPan.Text = "X";
            this.toolTip1.SetToolTip(this.lblCloseCashPan, "Close");
            this.lblCloseCashPan.Click += new System.EventHandler(this.lblCloseCashPan_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(3, -1);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(133, 19);
            this.label24.TabIndex = 28;
            this.label24.Text = "Customer name";
            // 
            // txtCusName
            // 
            this.txtCusName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCusName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusName.Location = new System.Drawing.Point(7, 25);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(275, 27);
            this.txtCusName.TabIndex = 192;
            this.toolTip1.SetToolTip(this.txtCusName, "customer name");
            // 
            // SalesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 555);
            this.Controls.Add(this.panCashCustomer);
            this.Controls.Add(this.panCusomter);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.SalesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panCusomter.ResumeLayout(false);
            this.panCusomter.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.panCashCustomer.ResumeLayout(false);
            this.panCashCustomer.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.LinkLabel linkrefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblCashAtHand;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReturnedSales;
        private System.Windows.Forms.Button btnCheque;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combPayment;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panCusomter;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblCloseCustomerPan;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSearchCustomers;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpCheque;
        private System.Windows.Forms.LinkLabel linkReturnItems;
        private System.Windows.Forms.Timer BillTimer;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtItemDiscount;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panCashCustomer;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblCloseCashPan;
        private System.Windows.Forms.Label label24;
    }
}