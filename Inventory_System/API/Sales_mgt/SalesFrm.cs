using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Inventory_System.Model;
using Inventory_System.Models;
using Inventory_System.API.Customers;
using Inventory_System.API.Reports;
using Inventory_System.API.Sales_mgt;
using Inventory_System.API.Notification;
using System.Drawing;

namespace Inventory_System.API
{
    public partial class SalesFrm : Form
    {
        private Products product = Factory.CreateProducts();
        private Category category = Factory.CreateCategory();
        private List<Products> cartItems = new List<Products>();
        private Sales Sell = Factory.CreateSales();
        private Customer buyer = Factory.CreateCustomer();
        private Cheque buyerCheque = Factory.CreateCheque();
        private DataSet ds;
        private DataTable Cart;
        private int Roleid;

        private int availQuantity ;
        private int ID;
        private bool cartSeelect = false;
        private int RemovingQty;
        private Decimal RemovingPrice;
        private Decimal RemovingDiscount;
        public SalesFrm(int roleid)
        {
            InitializeComponent();
            if (roleid != 1 && roleid !=2)
                throw new Exception("Access Denied: you do not have required privilege");
            Roleid = roleid;
            Cart = new DataTable();
            ds = new DataSet();
            Cart.Columns.AddRange(new DataColumn[6]
            {
                new DataColumn("ID", typeof(string)),
                new DataColumn("ProID", typeof(string)), 
                new DataColumn("Description", typeof(string)),
                new DataColumn("Quantity", typeof(int)),
                new DataColumn("Price", typeof(Decimal)),
                new DataColumn("Discount(%)", typeof(Decimal))
            });
            dgvCart.DataSource = Cart;
            dgvCart.Columns["ID"].Visible = false;
            dgvCart.Columns["ProID"].Visible = false;

            combBrand.DataSource = category.Display("");
            combBrand.DisplayMember = "BrandName";
            combBrand.ValueMember = "BrandID";
        }

        private void SalesFrm_Load(object sender, EventArgs e)
        {
            try { 
            DataGridStyle.StyleDatagridview(dgvStock);
            DataGridStyle.StyleDatagridview(dgvCart);
            DataGridStyle.StyleDatagridviewFixed(dgvCustomers);
            dgvStock.DataSource = product.Display("");
            dgvStock.Columns[0].Visible = false;
            dgvCustomers.DataSource = buyer.DisplayNames("");
            dgvCustomers.Columns[0].Visible = false;
            dgvCustomers.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            
                lblBillNo.Text = Sell.GenerateBillNo();
            BillTimer.Start();
            Sell.TodayTotalSales();
            lblTotalSales.Text = string.Format("{0:N}", Sell.TodayTotalSale);
            lblCashAtHand.Text = string.Format("{0:N}", Sell.CashTotalSale);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvStock.DataSource = product.Display(txtSearch.Text.Trim());
        }

      
        private void dgvStock_Click(object sender, EventArgs e)
        {
            Sell.ProID = dgvStock.SelectedRows[0].Cells[0].Value.ToString();
            lblDescription.Text =Sell.Description= dgvStock.SelectedRows[0].Cells[1].Value.ToString();
            lblSellingPrice.Text= dgvStock.SelectedRows[0].Cells[2].Value.ToString();
            Sell.SellingPrice = Convert.ToDecimal(dgvStock.SelectedRows[0].Cells[2].Value.ToString());
            availQuantity=Int32.Parse(dgvStock.SelectedRows[0].Cells[3].Value.ToString());
            txtQuantity.Focus();
        }
        
        private void linkrefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvStock.DataSource = product.Display("");
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sell.ProID == null)
                    throw new Exception("Please select a stock to add to cart");
          var items = Factory.CreateProducts();
                if (dgvStock.RowCount <= 0)
                    throw new Exception("No stock to sell");

                if (string.IsNullOrEmpty(txtQuantity.Text))
                    throw new Exception("Enter quantity to sell");
                Sell.Quantity =Int32.Parse( txtQuantity.Text);
                if (Sell.Quantity > availQuantity)
                    throw new Exception("Insufficient quantity available");
                //selected items for sale
                items.ProID = Sell.ProID;
                items.BrendName = category.GetCategoryByProduct(items.ProID);
                items.Quantity = Sell.Quantity; 
                items.Description = Sell.Description;
                items.ItemDiscount = 0.00m;
                if(!string.IsNullOrEmpty(txtItemDiscount.Text))
                        items.ItemDiscount = Convert.ToDecimal(txtItemDiscount.Text); 
                  items.SellingPrice = Sell.SellingPrice;
                  if (items.ItemDiscount == 0)
                  {
                      items.Total = items.SellingPrice * items.Quantity;
                  }
                  else
                  {
                    items.Total= items.SellingPrice * items.Quantity-((items.SellingPrice *items.Quantity)* items.ItemDiscount/100.00m);
                }
                
                Sell.TotalQuantity += Sell.Quantity;
                Sell.TotalAmount += items.Total; 
                //CHECK FOR DUPLICATES
                foreach (DataRow row in Cart.Rows)
                {
                    if (items.Description == row[2].ToString())
                        throw new Exception(String.Format("{0} already exist in the cart items", items.Description));
                } 
                 
                Cart.Rows.Add(ID, items.ProID,items.Description, items.Quantity, items.SellingPrice,items.ItemDiscount);
                //add items to cart
                cartItems.Add(items);

                txtQuantity.Clear();
                cartSeelect = false;

                //reset the controls
                lblDescription.Text = "";
                lblSellingPrice.Text = "0.00";
                txtQuantity.Clear();
                txtQuantity.Focus();
                txtItemDiscount.Clear();
                lblTotal.Text = string.Format("{0:N}", Sell.TotalAmount);
                ComputeBill();
                Sell.ProID = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) ||  e.KeyChar == (char)Keys.Back);
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || (char.IsPunctuation(e.KeyChar) || e.KeyChar == (char)Keys.Back));
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || (char.IsPunctuation(e.KeyChar) || e.KeyChar == (char)Keys.Back));
        }

        private void dgvCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCart.RowCount <= 0)
                    throw new Exception("No item to select");

                cartSeelect = true;
                RemovingQty = Int32.Parse(dgvCart.SelectedRows[0].Cells[3].Value.ToString());
                RemovingPrice = Convert.ToDecimal(dgvCart.SelectedRows[0].Cells[4].Value.ToString());
                RemovingDiscount = Convert.ToDecimal(dgvCart.SelectedRows[0].Cells[5].Value.ToString());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (cartSeelect)
                {
                    if (RemovingDiscount == 0)
                    {
                        Sell.TotalAmount -= (RemovingPrice * RemovingQty);
                    }
                    else
                    {
                        Sell.TotalAmount -= (RemovingPrice * RemovingQty-((RemovingPrice * RemovingQty)*RemovingDiscount/100.00m));
                    }

                    var removeindex = dgvCart.SelectedRows[0].Index;
                    Cart.Rows.RemoveAt(removeindex);//remove item from cart view
                    cartItems.RemoveAt(removeindex);//remove items from cart items
                    cartSeelect = false;
                    lblTotal.Text = Sell.TotalAmount.ToString();
                    ComputeBill();
                    //Reset the total amount and the grand total
                    //create a funcation to compute the total amount
                    //on each operation of add or removing stock from chart
                }
                else
                {
                    throw new Exception("Select an item to remove from cart");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void ComputeBill()
        {
            Decimal total=0.00m;
            Decimal netPay = 0.00m;
            if (!string.IsNullOrEmpty(txtDiscount.Text))
                Sell.Discount = Convert.ToDecimal(txtDiscount.Text);
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                Sell.PaidAmount = 0.00m;
            }
            else
            {
                Sell.PaidAmount = Convert.ToDecimal(txtAmount.Text);
            }
             
            total= Convert.ToDecimal(lblTotal.Text);
            if (Sell.Discount == 0.00m)
            {
                Sell.GrandTotal=netPay = total ;
                lblNetPay.Text = string.Format("{0:N}", netPay);
                lblBalance.Text = string.Format("{0:N}", (netPay - Sell.PaidAmount));
            }
            else
            {
              Sell.GrandTotal=  netPay = total - (total * Sell.Discount / 100.00m);
                lblNetPay.Text = string.Format("{0:N}", netPay);
                lblBalance.Text = string.Format("{0:N}", (netPay - Sell.PaidAmount));
            }
             
            Sell.Balance = Convert.ToDecimal(lblBalance.Text);
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var addCustomer = new RegisterCustomer();
            addCustomer.ShowDialog(); 
            buyer = addCustomer.GetCustomerDetails();
            if (buyer.Name != null)
            { 
                dgvCustomers.DataSource = buyer.DisplayNames(buyer.Name);
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
             
            var viewSales = new SalesInformationFrm(Roleid, btnSales.Text);
            viewSales.Show();
            Sell.TodayTotalSales();
            lblTotalSales.Text = string.Format("{0:N}", Sell.TodayTotalSale);
            lblCashAtHand.Text = string.Format("{0:N}", Sell.CashTotalSale);
        }

        private void btnCheque_Click(object sender, EventArgs e)
        {
            var viewSales = new SalesInformationFrm(Roleid, btnCheque.Text);
            viewSales.Show();
            Sell.TodayTotalSales();
            lblTotalSales.Text = string.Format("{0:N}", Sell.TodayTotalSale);
            lblCashAtHand.Text = string.Format("{0:N}", Sell.CashTotalSale);
        }

        private void btnReturnedSales_Click(object sender, EventArgs e)
        {
            var viewSales = new SalesInformationFrm(Roleid, btnReturnedSales.Text);
            viewSales.Show();
            Sell.TodayTotalSales();
            lblTotalSales.Text = string.Format("{0:N}", Sell.TodayTotalSale);
            lblCashAtHand.Text = string.Format("{0:N}", Sell.CashTotalSale);
        }

        private void combPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (combPayment.Text == "Cheque" )
                { 
                    panCusomter.Visible = true;
                    panCashCustomer.Visible = false;
                    txtAmount.Clear();
                }
                else if (combPayment.Text == "Cash")
                {
                    panCusomter.Visible = false;
                    panCashCustomer.Visible = true;
                    txtCusName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void Clear()
        {
            lblBalance.Text = "0.00";
            lblTotal.Text = "0.00";
            lblNetPay.Text = "0.00";
            txtAmount.Clear();
            txtDiscount.Clear();
            Sell.ProID = null;
            buyer.CusID = null; 
            cartItems.Clear();
            Cart.Rows.Clear();
            combPayment.ResetText();
            dtpCheque.Value = DateTime.Now;
            lblBillNo.Text = Sell.GenerateBillNo();
            cartSeelect = false;
            txtCusName.Clear();

            Sell.GrandTotal = 0.00m;
            Sell.TotalAmount = 0.00m;
            Sell.PaidAmount = 0.00m;
            Sell.Discount = 0.00m;
            Sell.TotalQuantity = 0;
        }
        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                if (combPayment.Text != "Cash" && combPayment.Text != "Cheque")
                    throw new Exception("Select payment type");
                if (combPayment.Text == "Cheque" && buyer.CusID == null) 
                    throw new Exception("Cheque sale must have customer details");
                Sell.GrandTotal = Convert.ToDecimal(lblNetPay.Text);
                Sell.PaidAmount = Convert.ToDecimal(txtAmount.Text);
                Sell.Balance = Convert.ToDecimal(lblBalance.Text);
                Sell.BillID = lblBillNo.Text;
                Sell.SalesType = combPayment.Text.Trim();
                Sell.Status = "Sold";
                if (combPayment.Text == "Cheque")
                {
                    Sell.MakeChequeSale(cartItems);
                }else if (combPayment.Text == "Cash")
                {
                    if (Sell.Balance != 0.00m)
                        throw new Exception("Cash sales cannot have balance left");
                    if (string.IsNullOrEmpty(txtCusName.Text))
                        throw new Exception("Please enter customer name");
                    buyer.Name = txtCusName.Text.Trim();
                    Sell.customer = buyer;
                    Sell.MakeSale(cartItems);
                    //Sell.MakeChequeSale(cartItems);
                }
                lblTotalSales.Text = string.Format("{0:N}", Sell.TodayTotalSale);
                lblCashAtHand.Text = string.Format("{0:N}", Sell.CashTotalSale);
                panCashCustomer.Visible = false;
                //display receipt for printing
                if (MessageTransactionFrm.Show("Successful", "Print Receipt ?", "Sale Transaction", "Yes", "No") ==
                    DialogResult.Yes)
                {
                    var receiptFrm = new ReceiptFrm(cartItems, Sell);
                    receiptFrm.ShowDialog();
                } 
                Cart.Rows.Clear();
                Clear();
                dgvStock.DataSource = product.Display(""); 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvCustomers_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.RowCount > 0)
            {
                buyer.CusID = dgvCustomers.SelectedRows[0].Cells[0].Value.ToString();
                buyer.Name = dgvCustomers.SelectedRows[0].Cells[1].Value.ToString();
                Sell.customer = buyer;
                buyerCheque.ChequeDate = dtpCheque.Value;
                Sell.CustomerCheque = buyerCheque;
                panCusomter.Visible = false;
                dgvCustomers.DataSource = buyer.DisplayNames("");
            }
            else
            {
                MessageBox.Show("No customer, add new customer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtpCheque_ValueChanged(object sender, EventArgs e)
        {
            buyerCheque.ChequeDate = dtpCheque.Value;
        }

        private void lblCloseCustomerPan_Click(object sender, EventArgs e)
        {
            panCusomter.Visible = false;
            dgvCustomers.DataSource = buyer.Display("");
        }

        private void txtSearchCustomers_TextChanged(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = buyer.DisplayNames(txtSearchCustomers.Text.Trim());
            
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            try { 
            Sell.PaidAmount = 0m;
            if (!string.IsNullOrEmpty(txtAmount.Text))
                Sell.PaidAmount = Convert.ToDecimal(txtAmount.Text);
            ComputeBill();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        }

        private void BillTimer_Tick(object sender, EventArgs e)
        {
            try { 
            if (Sell.BillNoExist(lblBillNo.Text))
                lblBillNo.Text = Sell.GenerateBillNo();
            }
            catch (Exception ex)
            {
            BillTimer.Stop();
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try { 
            Sell.Discount = 0m;
            if (!string.IsNullOrEmpty(txtDiscount.Text))
            {
                if (Convert.ToDecimal(txtDiscount.Text) > 100.00m) 
                    throw new Exception("Discount cannot exceed 100%");
                   
                Sell.Discount = Convert.ToDecimal(txtDiscount.Text);

                ComputeBill();
            }
            }
        catch (Exception ex)
        {
        MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        txtDiscount.Clear();
            }
        }

        private void linkReturnItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var returnItem = new ReturnItemSearchFrm();
            returnItem.Show();
            Sell.TodayTotalSales();
            lblTotalSales.Text = string.Format("{0:N}", Sell.TodayTotalSale);
            lblCashAtHand.Text = string.Format("{0:N}", Sell.CashTotalSale);
        }

        private void combBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvStock.DataSource = product.DisplayByBrand(combBrand.Text);
        }

        private void txtItemDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || (char.IsPunctuation(e.KeyChar) || e.KeyChar == (char)Keys.Back));
        }

        private void txtItemDiscount_TextChanged(object sender, EventArgs e)
        {
            try { 
            if (!string.IsNullOrEmpty(txtItemDiscount.Text))
            {
                if (Convert.ToDecimal(txtItemDiscount.Text) > 100.00m)
                {
                    txtItemDiscount.Clear();
                    throw new Exception("Discount cannot exceed 100%");
                   
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblCloseCashPan_Click(object sender, EventArgs e)
        {
            panCashCustomer.Visible = false;
            txtCusName.Clear();
        }
    }
}
