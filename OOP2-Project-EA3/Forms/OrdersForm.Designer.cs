using System.ComponentModel;
using System.Windows.Forms;

namespace OOP2_Project_EA3
{
    partial class OrdersForm
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
            this.ordersListLB.ItemHeight = 20;
            this.ordersListLB.Location = new System.Drawing.Point(217, 57);
            this.ordersListLB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ordersListLB.Name = "ordersListLB";
            this.ordersListLB.Size = new System.Drawing.Size(188, 424);
            this.ordersListLB.TabIndex = 0;
            this.ordersListLB.SelectedIndexChanged += new System.EventHandler(this.ordersListLB_SelectedIndexChanged);
            // 
            // processOrderBtn
            // 
            this.processOrderBtn.Location = new System.Drawing.Point(7, 35);
            this.processOrderBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.processOrderBtn.Name = "processOrderBtn";
            this.processOrderBtn.Size = new System.Drawing.Size(186, 76);
            this.processOrderBtn.TabIndex = 9;
            this.processOrderBtn.Text = "Process orders";
            this.processOrderBtn.UseVisualStyleBackColor = true;
            this.processOrderBtn.Click += new System.EventHandler(this.processOrderBtn_Click);
            // 
            // customerPhoneLabel
            // 
            this.customerPhoneLabel.AutoSize = true;
            this.customerPhoneLabel.Location = new System.Drawing.Point(426, 240);
            this.customerPhoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerPhoneLabel.Name = "customerPhoneLabel";
            this.customerPhoneLabel.Size = new System.Drawing.Size(118, 20);
            this.customerPhoneLabel.TabIndex = 8;
            this.customerPhoneLabel.Text = "Customer phone";
            // 
            // customerPhoneTB
            // 
            this.customerPhoneTB.Location = new System.Drawing.Point(426, 263);
            this.customerPhoneTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.customerPhoneTB.Name = "customerPhoneTB";
            this.customerPhoneTB.Size = new System.Drawing.Size(125, 27);
            this.customerPhoneTB.TabIndex = 7;
            // 
            // customerEmailTB
            // 
            this.customerEmailTB.Location = new System.Drawing.Point(426, 208);
            this.customerEmailTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.customerEmailTB.Name = "customerEmailTB";
            this.customerEmailTB.Size = new System.Drawing.Size(125, 27);
            this.customerEmailTB.TabIndex = 6;
            // 
            // customerEmailLabel
            // 
            this.customerEmailLabel.AutoSize = true;
            this.customerEmailLabel.Location = new System.Drawing.Point(426, 187);
            this.customerEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerEmailLabel.Name = "customerEmailLabel";
            this.customerEmailLabel.Size = new System.Drawing.Size(113, 20);
            this.customerEmailLabel.TabIndex = 5;
            this.customerEmailLabel.Text = "Customer email";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(426, 127);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(113, 20);
            this.customerNameLabel.TabIndex = 3;
            this.customerNameLabel.Text = "Customer name";
            // 
            // customerNameTB
            // 
            this.customerNameTB.Location = new System.Drawing.Point(426, 149);
            this.customerNameTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.customerNameTB.Name = "customerNameTB";
            this.customerNameTB.Size = new System.Drawing.Size(125, 27);
            this.customerNameTB.TabIndex = 4;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(426, 71);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(118, 20);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date dispatched";
            // 
            // dateTB
            // 
            this.dateTB.Location = new System.Drawing.Point(426, 93);
            this.dateTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(125, 27);
            this.dateTB.TabIndex = 2;
            // 
            // orderListLabel
            // 
            this.orderListLabel.AutoSize = true;
            this.orderListLabel.Location = new System.Drawing.Point(217, 35);
            this.orderListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderListLabel.Name = "orderListLabel";
            this.orderListLabel.Size = new System.Drawing.Size(130, 20);
            this.orderListLabel.TabIndex = 15;
            this.orderListLabel.Text = "Dispatched orders";
            // 
            // addNewOrderBtn
            // 
            this.addNewOrderBtn.Location = new System.Drawing.Point(7, 127);
            this.addNewOrderBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addNewOrderBtn.Name = "addNewOrderBtn";
            this.addNewOrderBtn.Size = new System.Drawing.Size(186, 57);
            this.addNewOrderBtn.TabIndex = 16;
            this.addNewOrderBtn.Text = "Add new order";
            this.addNewOrderBtn.UseVisualStyleBackColor = true;
            this.addNewOrderBtn.Click += new System.EventHandler(this.addNewOrderBtn_Click);
            // 
            // pendingOrdersRBtn
            // 
            this.pendingOrdersRBtn.AutoSize = true;
            this.pendingOrdersRBtn.Location = new System.Drawing.Point(29, 249);
            this.pendingOrdersRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pendingOrdersRBtn.Name = "pendingOrdersRBtn";
            this.pendingOrdersRBtn.Size = new System.Drawing.Size(129, 24);
            this.pendingOrdersRBtn.TabIndex = 17;
            this.pendingOrdersRBtn.TabStop = true;
            this.pendingOrdersRBtn.Text = "Pending orders";
            this.pendingOrdersRBtn.UseVisualStyleBackColor = true;
            this.pendingOrdersRBtn.CheckedChanged += new System.EventHandler(this.pendingOrdersRBtn_CheckedChanged);
            // 
            // dispatchedOrdersRBtn
            // 
            this.dispatchedOrdersRBtn.AutoSize = true;
            this.dispatchedOrdersRBtn.Checked = true;
            this.dispatchedOrdersRBtn.Location = new System.Drawing.Point(29, 223);
            this.dispatchedOrdersRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dispatchedOrdersRBtn.Name = "dispatchedOrdersRBtn";
            this.dispatchedOrdersRBtn.Size = new System.Drawing.Size(151, 24);
            this.dispatchedOrdersRBtn.TabIndex = 18;
            this.dispatchedOrdersRBtn.TabStop = true;
            this.dispatchedOrdersRBtn.Text = "Dispatched orders";
            this.dispatchedOrdersRBtn.UseVisualStyleBackColor = true;
            this.dispatchedOrdersRBtn.CheckedChanged += new System.EventHandler(this.dispatchedOrdersRBtn_CheckedChanged);
            // 
            // orderLineListLB
            // 
            this.orderLineListLB.FormattingEnabled = true;
            this.orderLineListLB.ItemHeight = 20;
            this.orderLineListLB.Location = new System.Drawing.Point(571, 57);
            this.orderLineListLB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.orderLineListLB.Name = "orderLineListLB";
            this.orderLineListLB.Size = new System.Drawing.Size(169, 424);
            this.orderLineListLB.TabIndex = 19;
            // 
            // orderLineListLabel
            // 
            this.orderLineListLabel.AutoSize = true;
            this.orderLineListLabel.Location = new System.Drawing.Point(571, 35);
            this.orderLineListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderLineListLabel.Name = "orderLineListLabel";
            this.orderLineListLabel.Size = new System.Drawing.Size(126, 20);
            this.orderLineListLabel.TabIndex = 20;
            this.orderLineListLabel.Text = "Ordered products";
            // 
            // customerPendingListLB
            // 
            this.customerPendingListLB.FormattingEnabled = true;
            this.customerPendingListLB.ItemHeight = 20;
            this.customerPendingListLB.Location = new System.Drawing.Point(783, 57);
            this.customerPendingListLB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.customerPendingListLB.Name = "customerPendingListLB";
            this.customerPendingListLB.Size = new System.Drawing.Size(203, 424);
            this.customerPendingListLB.TabIndex = 21;
            // 
            // customersPendingListLabel
            // 
            this.customersPendingListLabel.AutoSize = true;
            this.customersPendingListLabel.Location = new System.Drawing.Point(783, 35);
            this.customersPendingListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customersPendingListLabel.Name = "customersPendingListLabel";
            this.customersPendingListLabel.Size = new System.Drawing.Size(215, 20);
            this.customersPendingListLabel.TabIndex = 22;
            this.customersPendingListLabel.Text = "Customers with pending orders";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 697);
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
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "OrdersForm";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ordersListLB;
        private Button processOrderBtn;
        private Label customerPhoneLabel;
        private TextBox customerPhoneTB;
        private TextBox customerEmailTB;
        private Label customerEmailLabel;
        private Label customerNameLabel;
        private TextBox customerNameTB;
        private Label dateLabel;
        private TextBox dateTB;
        private Label orderListLabel;
        private Button addNewOrderBtn;
        private RadioButton pendingOrdersRBtn;
        private RadioButton dispatchedOrdersRBtn;
        private ListBox orderLineListLB;
        private Label orderLineListLabel;
        private ListBox customerPendingListLB;
        private Label customersPendingListLabel;
    }
}