namespace OOP2_Project_EA3
{
    partial class OrdersForm
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
            this.ordersListLB = new System.Windows.Forms.ListBox();
            this.processOrderBtn = new System.Windows.Forms.Button();
            this.customerPhoneLabel = new System.Windows.Forms.Label();
            this.customerPhoneTB = new System.Windows.Forms.TextBox();
            this.customerEmailTB = new System.Windows.Forms.TextBox();
            this.customerEmailLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTB = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTB = new System.Windows.Forms.TextBox();
            this.orderListLabel = new System.Windows.Forms.Label();
            this.addNewOrderBtn = new System.Windows.Forms.Button();
            this.pendingOrdersRBtn = new System.Windows.Forms.RadioButton();
            this.dispatchedOrdersRBtn = new System.Windows.Forms.RadioButton();
            this.orderLineListLB = new System.Windows.Forms.ListBox();
            this.orderLineListLabel = new System.Windows.Forms.Label();
            this.customerPendingListLB = new System.Windows.Forms.ListBox();
            this.customersPendingListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ordersListLB
            // 
            this.ordersListLB.FormattingEnabled = true;
            this.ordersListLB.ItemHeight = 32;
            this.ordersListLB.Location = new System.Drawing.Point(353, 91);
            this.ordersListLB.Name = "ordersListLB";
            this.ordersListLB.Size = new System.Drawing.Size(303, 676);
            this.ordersListLB.TabIndex = 0;
            // 
            // processOrderBtn
            // 
            this.processOrderBtn.Location = new System.Drawing.Point(12, 56);
            this.processOrderBtn.Name = "processOrderBtn";
            this.processOrderBtn.Size = new System.Drawing.Size(303, 121);
            this.processOrderBtn.TabIndex = 9;
            this.processOrderBtn.Text = "Process orders";
            this.processOrderBtn.UseVisualStyleBackColor = true;
            // 
            // customerPhoneLabel
            // 
            this.customerPhoneLabel.AutoSize = true;
            this.customerPhoneLabel.Location = new System.Drawing.Point(693, 385);
            this.customerPhoneLabel.Name = "customerPhoneLabel";
            this.customerPhoneLabel.Size = new System.Drawing.Size(193, 32);
            this.customerPhoneLabel.TabIndex = 8;
            this.customerPhoneLabel.Text = "Customer phone";
            // 
            // customerPhoneTB
            // 
            this.customerPhoneTB.Location = new System.Drawing.Point(693, 420);
            this.customerPhoneTB.Name = "customerPhoneTB";
            this.customerPhoneTB.Size = new System.Drawing.Size(200, 39);
            this.customerPhoneTB.TabIndex = 7;
            // 
            // customerEmailTB
            // 
            this.customerEmailTB.Location = new System.Drawing.Point(693, 333);
            this.customerEmailTB.Name = "customerEmailTB";
            this.customerEmailTB.Size = new System.Drawing.Size(200, 39);
            this.customerEmailTB.TabIndex = 6;
            // 
            // customerEmailLabel
            // 
            this.customerEmailLabel.AutoSize = true;
            this.customerEmailLabel.Location = new System.Drawing.Point(693, 298);
            this.customerEmailLabel.Name = "customerEmailLabel";
            this.customerEmailLabel.Size = new System.Drawing.Size(182, 32);
            this.customerEmailLabel.TabIndex = 5;
            this.customerEmailLabel.Text = "Customer email";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(693, 203);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(184, 32);
            this.customerNameLabel.TabIndex = 3;
            this.customerNameLabel.Text = "Customer name";
            // 
            // customerNameTB
            // 
            this.customerNameTB.Location = new System.Drawing.Point(693, 239);
            this.customerNameTB.Name = "customerNameTB";
            this.customerNameTB.Size = new System.Drawing.Size(200, 39);
            this.customerNameTB.TabIndex = 4;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(693, 114);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(187, 32);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Dispatched date";
            // 
            // dateTB
            // 
            this.dateTB.Location = new System.Drawing.Point(693, 149);
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(200, 39);
            this.dateTB.TabIndex = 2;
            // 
            // orderListLabel
            // 
            this.orderListLabel.AutoSize = true;
            this.orderListLabel.Location = new System.Drawing.Point(353, 56);
            this.orderListLabel.Name = "orderListLabel";
            this.orderListLabel.Size = new System.Drawing.Size(207, 32);
            this.orderListLabel.TabIndex = 15;
            this.orderListLabel.Text = "Dispatched orders";
            // 
            // addNewOrderBtn
            // 
            this.addNewOrderBtn.Location = new System.Drawing.Point(12, 203);
            this.addNewOrderBtn.Name = "addNewOrderBtn";
            this.addNewOrderBtn.Size = new System.Drawing.Size(303, 92);
            this.addNewOrderBtn.TabIndex = 16;
            this.addNewOrderBtn.Text = "Add new order";
            this.addNewOrderBtn.UseVisualStyleBackColor = true;
            // 
            // pendingOrdersRBtn
            // 
            this.pendingOrdersRBtn.AutoSize = true;
            this.pendingOrdersRBtn.Location = new System.Drawing.Point(47, 398);
            this.pendingOrdersRBtn.Name = "pendingOrdersRBtn";
            this.pendingOrdersRBtn.Size = new System.Drawing.Size(206, 36);
            this.pendingOrdersRBtn.TabIndex = 17;
            this.pendingOrdersRBtn.TabStop = true;
            this.pendingOrdersRBtn.Text = "Pending orders";
            this.pendingOrdersRBtn.UseVisualStyleBackColor = true;
            // 
            // dispatchedOrdersRBtn
            // 
            this.dispatchedOrdersRBtn.AutoSize = true;
            this.dispatchedOrdersRBtn.Location = new System.Drawing.Point(47, 356);
            this.dispatchedOrdersRBtn.Name = "dispatchedOrdersRBtn";
            this.dispatchedOrdersRBtn.Size = new System.Drawing.Size(238, 36);
            this.dispatchedOrdersRBtn.TabIndex = 18;
            this.dispatchedOrdersRBtn.TabStop = true;
            this.dispatchedOrdersRBtn.Text = "Dispatched orders";
            this.dispatchedOrdersRBtn.UseVisualStyleBackColor = true;
            // 
            // orderLineListLB
            // 
            this.orderLineListLB.FormattingEnabled = true;
            this.orderLineListLB.ItemHeight = 32;
            this.orderLineListLB.Location = new System.Drawing.Point(928, 91);
            this.orderLineListLB.Name = "orderLineListLB";
            this.orderLineListLB.Size = new System.Drawing.Size(272, 676);
            this.orderLineListLB.TabIndex = 19;
            // 
            // orderLineListLabel
            // 
            this.orderLineListLabel.AutoSize = true;
            this.orderLineListLabel.Location = new System.Drawing.Point(928, 56);
            this.orderLineListLabel.Name = "orderLineListLabel";
            this.orderLineListLabel.Size = new System.Drawing.Size(202, 32);
            this.orderLineListLabel.TabIndex = 20;
            this.orderLineListLabel.Text = "Ordered products";
            // 
            // customerPendingListLB
            // 
            this.customerPendingListLB.FormattingEnabled = true;
            this.customerPendingListLB.ItemHeight = 32;
            this.customerPendingListLB.Location = new System.Drawing.Point(1272, 91);
            this.customerPendingListLB.Name = "customerPendingListLB";
            this.customerPendingListLB.Size = new System.Drawing.Size(328, 676);
            this.customerPendingListLB.TabIndex = 21;
            // 
            // customersPendingListLabel
            // 
            this.customersPendingListLabel.AutoSize = true;
            this.customersPendingListLabel.Location = new System.Drawing.Point(1272, 56);
            this.customersPendingListLabel.Name = "customersPendingListLabel";
            this.customersPendingListLabel.Size = new System.Drawing.Size(349, 32);
            this.customersPendingListLabel.TabIndex = 22;
            this.customersPendingListLabel.Text = "Customers with pending orders";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1697, 1115);
            this.Controls.Add(this.customersPendingListLabel);
            this.Controls.Add(this.customerPendingListLB);
            this.Controls.Add(this.orderLineListLabel);
            this.Controls.Add(this.orderLineListLB);
            this.Controls.Add(this.dispatchedOrdersRBtn);
            this.Controls.Add(this.pendingOrdersRBtn);
            this.Controls.Add(this.addNewOrderBtn);
            this.Controls.Add(this.orderListLabel);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.customerNameTB);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerEmailLabel);
            this.Controls.Add(this.customerEmailTB);
            this.Controls.Add(this.customerPhoneTB);
            this.Controls.Add(this.customerPhoneLabel);
            this.Controls.Add(this.processOrderBtn);
            this.Controls.Add(this.ordersListLB);
            this.Name = "OrdersForm";
            this.Text = "Estimated dispatch date";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ordersListLB;
        private System.Windows.Forms.Button processOrderBtn;
        private System.Windows.Forms.Label customerPhoneLabel;
        private System.Windows.Forms.TextBox customerPhoneTB;
        private System.Windows.Forms.TextBox customerEmailTB;
        private System.Windows.Forms.Label customerEmailLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTB;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateTB;
        private System.Windows.Forms.Label orderListLabel;
        private System.Windows.Forms.Button addNewOrderBtn;
        private System.Windows.Forms.RadioButton pendingOrdersRBtn;
        private System.Windows.Forms.RadioButton dispatchedOrdersRBtn;
        private System.Windows.Forms.ListBox orderLineListLB;
        private System.Windows.Forms.Label orderLineListLabel;
        private System.Windows.Forms.ListBox customerPendingListLB;
        private System.Windows.Forms.Label customersPendingListLabel;
    }
}