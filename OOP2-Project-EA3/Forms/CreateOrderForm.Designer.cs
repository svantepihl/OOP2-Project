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
            ((System.ComponentModel.ISupportInitialize)(this.selectQuantityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // selectCustomerListLB
            // 
            this.selectCustomerListLB.FormattingEnabled = true;
            this.selectCustomerListLB.ItemHeight = 32;
            this.selectCustomerListLB.Location = new System.Drawing.Point(44, 49);
            this.selectCustomerListLB.Name = "selectCustomerListLB";
            this.selectCustomerListLB.Size = new System.Drawing.Size(308, 644);
            this.selectCustomerListLB.TabIndex = 0;
            // 
            // selectProductListLB
            // 
            this.selectProductListLB.FormattingEnabled = true;
            this.selectProductListLB.ItemHeight = 32;
            this.selectProductListLB.Location = new System.Drawing.Point(405, 49);
            this.selectProductListLB.Name = "selectProductListLB";
            this.selectProductListLB.Size = new System.Drawing.Size(256, 580);
            this.selectProductListLB.TabIndex = 1;
            // 
            // selectedProductsListLB
            // 
            this.selectedProductsListLB.FormattingEnabled = true;
            this.selectedProductsListLB.ItemHeight = 32;
            this.selectedProductsListLB.Location = new System.Drawing.Point(704, 49);
            this.selectedProductsListLB.Name = "selectedProductsListLB";
            this.selectedProductsListLB.Size = new System.Drawing.Size(268, 580);
            this.selectedProductsListLB.TabIndex = 2;
            // 
            // selectQuantityNUD
            // 
            this.selectQuantityNUD.Location = new System.Drawing.Point(405, 649);
            this.selectQuantityNUD.Name = "selectQuantityNUD";
            this.selectQuantityNUD.Size = new System.Drawing.Size(82, 39);
            this.selectQuantityNUD.TabIndex = 3;
            // 
            // addSelectedProductBtn
            // 
            this.addSelectedProductBtn.Location = new System.Drawing.Point(511, 644);
            this.addSelectedProductBtn.Name = "addSelectedProductBtn";
            this.addSelectedProductBtn.Size = new System.Drawing.Size(150, 46);
            this.addSelectedProductBtn.TabIndex = 4;
            this.addSelectedProductBtn.Text = "Add";
            this.addSelectedProductBtn.UseVisualStyleBackColor = true;
            // 
            // shippingAdressTB
            // 
            this.shippingAdressTB.Location = new System.Drawing.Point(1023, 160);
            this.shippingAdressTB.Name = "shippingAdressTB";
            this.shippingAdressTB.Size = new System.Drawing.Size(335, 39);
            this.shippingAdressTB.TabIndex = 5;
            // 
            // shippingAddressLabel
            // 
            this.shippingAddressLabel.AutoSize = true;
            this.shippingAddressLabel.Location = new System.Drawing.Point(1023, 116);
            this.shippingAddressLabel.Name = "shippingAddressLabel";
            this.shippingAddressLabel.Size = new System.Drawing.Size(197, 32);
            this.shippingAddressLabel.TabIndex = 6;
            this.shippingAddressLabel.Text = "Shipping address";
            // 
            // orderPaidRBtn
            // 
            this.orderPaidRBtn.AutoSize = true;
            this.orderPaidRBtn.Location = new System.Drawing.Point(1023, 235);
            this.orderPaidRBtn.Name = "orderPaidRBtn";
            this.orderPaidRBtn.Size = new System.Drawing.Size(153, 36);
            this.orderPaidRBtn.TabIndex = 7;
            this.orderPaidRBtn.TabStop = true;
            this.orderPaidRBtn.Text = "Paid order";
            this.orderPaidRBtn.UseVisualStyleBackColor = true;
            // 
            // orderUnpaidRBtn
            // 
            this.orderUnpaidRBtn.AutoSize = true;
            this.orderUnpaidRBtn.Location = new System.Drawing.Point(1023, 278);
            this.orderUnpaidRBtn.Name = "orderUnpaidRBtn";
            this.orderUnpaidRBtn.Size = new System.Drawing.Size(185, 36);
            this.orderUnpaidRBtn.TabIndex = 8;
            this.orderUnpaidRBtn.TabStop = true;
            this.orderUnpaidRBtn.Text = "Unpaid order";
            this.orderUnpaidRBtn.UseVisualStyleBackColor = true;
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.Location = new System.Drawing.Point(1023, 547);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.Size = new System.Drawing.Size(335, 82);
            this.placeOrderBtn.TabIndex = 9;
            this.placeOrderBtn.Text = "Place order";
            this.placeOrderBtn.UseVisualStyleBackColor = true;
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 973);
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
            this.Name = "CreateOrderForm";
            this.Text = " ";
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
    }
}