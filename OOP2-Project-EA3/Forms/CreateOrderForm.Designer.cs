namespace OOP2_Project_EA3
{
    partial class CreateOrderForm
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
            ((System.ComponentModel.ISupportInitialize)(this.selectQuantityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // selectCustomerListLB
            // 
            this.selectCustomerListLB.FormattingEnabled = true;
            this.selectCustomerListLB.ItemHeight = 15;
            this.selectCustomerListLB.Location = new System.Drawing.Point(24, 23);
            this.selectCustomerListLB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.selectCustomerListLB.Name = "selectCustomerListLB";
            this.selectCustomerListLB.Size = new System.Drawing.Size(168, 274);
            this.selectCustomerListLB.TabIndex = 0;
            // 
            // selectProductListLB
            // 
            this.selectProductListLB.FormattingEnabled = true;
            this.selectProductListLB.ItemHeight = 15;
            this.selectProductListLB.Location = new System.Drawing.Point(218, 23);
            this.selectProductListLB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.selectProductListLB.Name = "selectProductListLB";
            this.selectProductListLB.Size = new System.Drawing.Size(140, 274);
            this.selectProductListLB.TabIndex = 1;
            // 
            // selectedProductsListLB
            // 
            this.selectedProductsListLB.FormattingEnabled = true;
            this.selectedProductsListLB.ItemHeight = 15;
            this.selectedProductsListLB.Location = new System.Drawing.Point(379, 23);
            this.selectedProductsListLB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.selectedProductsListLB.Name = "selectedProductsListLB";
            this.selectedProductsListLB.Size = new System.Drawing.Size(146, 274);
            this.selectedProductsListLB.TabIndex = 2;
            // 
            // selectQuantityNUD
            // 
            this.selectQuantityNUD.Location = new System.Drawing.Point(218, 304);
            this.selectQuantityNUD.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.selectQuantityNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectQuantityNUD.Name = "selectQuantityNUD";
            this.selectQuantityNUD.Size = new System.Drawing.Size(44, 23);
            this.selectQuantityNUD.TabIndex = 3;
            this.selectQuantityNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addSelectedProductBtn
            // 
            this.addSelectedProductBtn.Location = new System.Drawing.Point(275, 302);
            this.addSelectedProductBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addSelectedProductBtn.Name = "addSelectedProductBtn";
            this.addSelectedProductBtn.Size = new System.Drawing.Size(81, 22);
            this.addSelectedProductBtn.TabIndex = 4;
            this.addSelectedProductBtn.Text = "Add";
            this.addSelectedProductBtn.UseVisualStyleBackColor = true;
            // 
            // shippingAdressTB
            // 
            this.shippingAdressTB.Location = new System.Drawing.Point(551, 101);
            this.shippingAdressTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.shippingAdressTB.Name = "shippingAdressTB";
            this.shippingAdressTB.Size = new System.Drawing.Size(182, 23);
            this.shippingAdressTB.TabIndex = 5;
            // 
            // shippingAddressLabel
            // 
            this.shippingAddressLabel.AutoSize = true;
            this.shippingAddressLabel.Location = new System.Drawing.Point(551, 80);
            this.shippingAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shippingAddressLabel.Name = "shippingAddressLabel";
            this.shippingAddressLabel.Size = new System.Drawing.Size(97, 15);
            this.shippingAddressLabel.TabIndex = 6;
            this.shippingAddressLabel.Text = "Shipping address";
            // 
            // orderPaidRBtn
            // 
            this.orderPaidRBtn.AutoSize = true;
            this.orderPaidRBtn.Location = new System.Drawing.Point(551, 136);
            this.orderPaidRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.orderPaidRBtn.Name = "orderPaidRBtn";
            this.orderPaidRBtn.Size = new System.Drawing.Size(79, 19);
            this.orderPaidRBtn.TabIndex = 7;
            this.orderPaidRBtn.TabStop = true;
            this.orderPaidRBtn.Text = "Paid order";
            this.orderPaidRBtn.UseVisualStyleBackColor = true;
            // 
            // orderUnpaidRBtn
            // 
            this.orderUnpaidRBtn.AutoSize = true;
            this.orderUnpaidRBtn.Location = new System.Drawing.Point(551, 156);
            this.orderUnpaidRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.orderUnpaidRBtn.Name = "orderUnpaidRBtn";
            this.orderUnpaidRBtn.Size = new System.Drawing.Size(94, 19);
            this.orderUnpaidRBtn.TabIndex = 8;
            this.orderUnpaidRBtn.TabStop = true;
            this.orderUnpaidRBtn.Text = "Unpaid order";
            this.orderUnpaidRBtn.UseVisualStyleBackColor = true;
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.Location = new System.Drawing.Point(551, 256);
            this.placeOrderBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.Size = new System.Drawing.Size(180, 38);
            this.placeOrderBtn.TabIndex = 9;
            this.placeOrderBtn.Text = "Place order";
            this.placeOrderBtn.UseVisualStyleBackColor = true;
            // 
            // selectCustomerBtn
            // 
            this.selectCustomerBtn.Location = new System.Drawing.Point(24, 304);
            this.selectCustomerBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.selectCustomerBtn.Name = "selectCustomerBtn";
            this.selectCustomerBtn.Size = new System.Drawing.Size(166, 22);
            this.selectCustomerBtn.TabIndex = 10;
            this.selectCustomerBtn.Text = "Select customer";
            this.selectCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(551, 23);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(92, 15);
            this.customerNameLabel.TabIndex = 11;
            this.customerNameLabel.Text = "Customer name";
            // 
            // customerNameTB
            // 
            this.customerNameTB.Location = new System.Drawing.Point(551, 39);
            this.customerNameTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.customerNameTB.Name = "customerNameTB";
            this.customerNameTB.ReadOnly = true;
            this.customerNameTB.Size = new System.Drawing.Size(110, 23);
            this.customerNameTB.TabIndex = 12;
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 456);
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

        private System.Windows.Forms.ListBox selectCustomerListLB;
        private System.Windows.Forms.ListBox selectProductListLB;
        private System.Windows.Forms.ListBox selectedProductsListLB;
        private System.Windows.Forms.NumericUpDown selectQuantityNUD;
        private System.Windows.Forms.Button addSelectedProductBtn;
        private System.Windows.Forms.TextBox shippingAdressTB;
        private System.Windows.Forms.Label shippingAddressLabel;
        private System.Windows.Forms.RadioButton orderPaidRBtn;
        private System.Windows.Forms.RadioButton orderUnpaidRBtn;
        private System.Windows.Forms.Button placeOrderBtn;
        private System.Windows.Forms.Button selectCustomerBtn;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTB;
    }
}