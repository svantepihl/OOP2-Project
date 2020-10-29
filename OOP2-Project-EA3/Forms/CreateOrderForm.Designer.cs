using System.ComponentModel;
using System.Windows.Forms;

namespace OOP2_Project_EA3
{
    partial class CreateOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.selectCustomerListLB = new System.Windows.Forms.ListBox();
            this.selectProductListLB = new System.Windows.Forms.ListBox();
            this.selectedProductsListLB = new System.Windows.Forms.ListBox();
            this.selectQuantityNUD = new System.Windows.Forms.NumericUpDown();
            this.addSelectedProductBtn = new System.Windows.Forms.Button();
            this.shippingAdressTB = new System.Windows.Forms.TextBox();
            this.shippingAddressLabel = new System.Windows.Forms.Label();
            this.orderPaidRBtn = new System.Windows.Forms.RadioButton();
            this.orderUnpaidRBtn = new System.Windows.Forms.RadioButton();
            this.placeOrderBtn = new System.Windows.Forms.Button();
            this.selectCustomerBtn = new System.Windows.Forms.Button();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTB = new System.Windows.Forms.TextBox();
            this.removeSelectedProductBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectQuantityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // selectCustomerListLB
            // 
            this.selectCustomerListLB.FormattingEnabled = true;
            this.selectCustomerListLB.ItemHeight = 20;
            this.selectCustomerListLB.Location = new System.Drawing.Point(27, 31);
            this.selectCustomerListLB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.selectCustomerListLB.Name = "selectCustomerListLB";
            this.selectCustomerListLB.Size = new System.Drawing.Size(191, 364);
            this.selectCustomerListLB.TabIndex = 0;
            // 
            // selectProductListLB
            // 
            this.selectProductListLB.FormattingEnabled = true;
            this.selectProductListLB.ItemHeight = 20;
            this.selectProductListLB.Location = new System.Drawing.Point(249, 31);
            this.selectProductListLB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.selectProductListLB.Name = "selectProductListLB";
            this.selectProductListLB.Size = new System.Drawing.Size(159, 364);
            this.selectProductListLB.TabIndex = 1;
            // 
            // selectedProductsListLB
            // 
            this.selectedProductsListLB.FormattingEnabled = true;
            this.selectedProductsListLB.ItemHeight = 20;
            this.selectedProductsListLB.Location = new System.Drawing.Point(435, 31);
            this.selectedProductsListLB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.selectedProductsListLB.Name = "selectedProductsListLB";
            this.selectedProductsListLB.Size = new System.Drawing.Size(166, 364);
            this.selectedProductsListLB.TabIndex = 2;
            // 
            // selectQuantityNUD
            // 
            this.selectQuantityNUD.Location = new System.Drawing.Point(249, 405);
            this.selectQuantityNUD.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.selectQuantityNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectQuantityNUD.Name = "selectQuantityNUD";
            this.selectQuantityNUD.Size = new System.Drawing.Size(50, 27);
            this.selectQuantityNUD.TabIndex = 3;
            this.selectQuantityNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectQuantityNUD.ValueChanged += new System.EventHandler(this.selectQuantityNUD_ValueChanged);
            // 
            // addSelectedProductBtn
            // 
            this.addSelectedProductBtn.Location = new System.Drawing.Point(314, 403);
            this.addSelectedProductBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addSelectedProductBtn.Name = "addSelectedProductBtn";
            this.addSelectedProductBtn.Size = new System.Drawing.Size(93, 29);
            this.addSelectedProductBtn.TabIndex = 4;
            this.addSelectedProductBtn.Text = "Add";
            this.addSelectedProductBtn.UseVisualStyleBackColor = true;
            this.addSelectedProductBtn.Click += new System.EventHandler(this.addSelectedProductBtn_Click);
            // 
            // shippingAdressTB
            // 
            this.shippingAdressTB.Location = new System.Drawing.Point(630, 135);
            this.shippingAdressTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.shippingAdressTB.Name = "shippingAdressTB";
            this.shippingAdressTB.Size = new System.Drawing.Size(207, 27);
            this.shippingAdressTB.TabIndex = 5;
            this.shippingAdressTB.TextChanged += new System.EventHandler(this.shippingAdressTB_TextChanged);
            // 
            // shippingAddressLabel
            // 
            this.shippingAddressLabel.AutoSize = true;
            this.shippingAddressLabel.Location = new System.Drawing.Point(630, 107);
            this.shippingAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shippingAddressLabel.Name = "shippingAddressLabel";
            this.shippingAddressLabel.Size = new System.Drawing.Size(123, 20);
            this.shippingAddressLabel.TabIndex = 6;
            this.shippingAddressLabel.Text = "Shipping address";
            // 
            // orderPaidRBtn
            // 
            this.orderPaidRBtn.AutoSize = true;
            this.orderPaidRBtn.Location = new System.Drawing.Point(630, 181);
            this.orderPaidRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.orderPaidRBtn.Name = "orderPaidRBtn";
            this.orderPaidRBtn.Size = new System.Drawing.Size(98, 24);
            this.orderPaidRBtn.TabIndex = 7;
            this.orderPaidRBtn.TabStop = true;
            this.orderPaidRBtn.Text = "Paid order";
            this.orderPaidRBtn.UseVisualStyleBackColor = true;
            this.orderPaidRBtn.CheckedChanged += new System.EventHandler(this.orderPaidRBtn_CheckedChanged);
            // 
            // orderUnpaidRBtn
            // 
            this.orderUnpaidRBtn.AutoSize = true;
            this.orderUnpaidRBtn.Location = new System.Drawing.Point(630, 208);
            this.orderUnpaidRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.orderUnpaidRBtn.Name = "orderUnpaidRBtn";
            this.orderUnpaidRBtn.Size = new System.Drawing.Size(118, 24);
            this.orderUnpaidRBtn.TabIndex = 8;
            this.orderUnpaidRBtn.TabStop = true;
            this.orderUnpaidRBtn.Text = "Unpaid order";
            this.orderUnpaidRBtn.UseVisualStyleBackColor = true;
            this.orderUnpaidRBtn.CheckedChanged += new System.EventHandler(this.orderUnpaidRBtn_CheckedChanged);
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.Location = new System.Drawing.Point(630, 341);
            this.placeOrderBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.Size = new System.Drawing.Size(206, 51);
            this.placeOrderBtn.TabIndex = 9;
            this.placeOrderBtn.Text = "Place order";
            this.placeOrderBtn.UseVisualStyleBackColor = true;
            this.placeOrderBtn.Click += new System.EventHandler(this.placeOrderBtn_Click);
            // 
            // selectCustomerBtn
            // 
            this.selectCustomerBtn.Location = new System.Drawing.Point(27, 405);
            this.selectCustomerBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.selectCustomerBtn.Name = "selectCustomerBtn";
            this.selectCustomerBtn.Size = new System.Drawing.Size(190, 29);
            this.selectCustomerBtn.TabIndex = 10;
            this.selectCustomerBtn.Text = "Select customer";
            this.selectCustomerBtn.UseVisualStyleBackColor = true;
            this.selectCustomerBtn.Click += new System.EventHandler(this.selectCustomerBtn_Click);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(630, 31);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(113, 20);
            this.customerNameLabel.TabIndex = 11;
            this.customerNameLabel.Text = "Customer name";
            // 
            // customerNameTB
            // 
            this.customerNameTB.Location = new System.Drawing.Point(630, 52);
            this.customerNameTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.customerNameTB.Name = "customerNameTB";
            this.customerNameTB.ReadOnly = true;
            this.customerNameTB.Size = new System.Drawing.Size(125, 27);
            this.customerNameTB.TabIndex = 12;
            // 
            // removeSelectedProductBtn
            // 
            this.removeSelectedProductBtn.Location = new System.Drawing.Point(507, 403);
            this.removeSelectedProductBtn.Name = "removeSelectedProductBtn";
            this.removeSelectedProductBtn.Size = new System.Drawing.Size(94, 27);
            this.removeSelectedProductBtn.TabIndex = 13;
            this.removeSelectedProductBtn.Text = "Remove";
            this.removeSelectedProductBtn.UseVisualStyleBackColor = true;
            this.removeSelectedProductBtn.Click += new System.EventHandler(this.removeSelectedProductBtn_Click);
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 608);
            this.Controls.Add(this.removeSelectedProductBtn);
            this.Controls.Add(this.customerNameTB);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.selectCustomerBtn);
            this.Controls.Add(this.placeOrderBtn);
            this.Controls.Add(this.orderUnpaidRBtn);
            this.Controls.Add(this.orderPaidRBtn);
            this.Controls.Add(this.shippingAddressLabel);
            this.Controls.Add(this.shippingAdressTB);
            this.Controls.Add(this.addSelectedProductBtn);
            this.Controls.Add(this.selectQuantityNUD);
            this.Controls.Add(this.selectedProductsListLB);
            this.Controls.Add(this.selectProductListLB);
            this.Controls.Add(this.selectCustomerListLB);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "CreateOrderForm";
            this.Text = " Create new order";
            ((System.ComponentModel.ISupportInitialize)(this.selectQuantityNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox selectCustomerListLB;
        private ListBox selectProductListLB;
        private ListBox selectedProductsListLB;
        private NumericUpDown selectQuantityNUD;
        private Button addSelectedProductBtn;
        private TextBox shippingAdressTB;
        private Label shippingAddressLabel;
        private RadioButton orderPaidRBtn;
        private RadioButton orderUnpaidRBtn;
        private Button placeOrderBtn;
        private Button selectCustomerBtn;
        private Label customerNameLabel;
        private TextBox customerNameTB;
        private Button removeSelectedProductBtn;
    }
}