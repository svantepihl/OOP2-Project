namespace OOP2_Project_EA3
{
    partial class CustomerForm
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
            this.customerListLB = new System.Windows.Forms.ListBox();
            this.customerNumberLabel = new System.Windows.Forms.Label();
            this.customerNumberTB = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTB = new System.Windows.Forms.TextBox();
            this.customerPhoneLabel = new System.Windows.Forms.Label();
            this.customerPhoneTB = new System.Windows.Forms.TextBox();
            this.customerEmailTB = new System.Windows.Forms.TextBox();
            this.customerEmailLabel = new System.Windows.Forms.Label();
            this.createNewCustomerBtn = new System.Windows.Forms.Button();
            this.updateCustomerBtn = new System.Windows.Forms.Button();
            this.customerActiveRBtn = new System.Windows.Forms.RadioButton();
            this.customerArchivedRBtn = new System.Windows.Forms.RadioButton();
            this.customerOrderListLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // customerListLB
            // 
            this.customerListLB.FormattingEnabled = true;
            this.customerListLB.ItemHeight = 32;
            this.customerListLB.Location = new System.Drawing.Point(70, 121);
            this.customerListLB.Name = "customerListLB";
            this.customerListLB.Size = new System.Drawing.Size(303, 580);
            this.customerListLB.TabIndex = 0;
            // 
            // customerNumberLabel
            // 
            this.customerNumberLabel.AutoSize = true;
            this.customerNumberLabel.Location = new System.Drawing.Point(410, 144);
            this.customerNumberLabel.Name = "customerNumberLabel";
            this.customerNumberLabel.Size = new System.Drawing.Size(102, 32);
            this.customerNumberLabel.TabIndex = 1;
            this.customerNumberLabel.Text = "Number";
            // 
            // customerNumberTB
            // 
            this.customerNumberTB.Location = new System.Drawing.Point(410, 179);
            this.customerNumberTB.Name = "customerNumberTB";
            this.customerNumberTB.Size = new System.Drawing.Size(200, 39);
            this.customerNumberTB.TabIndex = 2;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(410, 233);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(78, 32);
            this.customerNameLabel.TabIndex = 3;
            this.customerNameLabel.Text = "Name";
            // 
            // customerNameTB
            // 
            this.customerNameTB.Location = new System.Drawing.Point(410, 269);
            this.customerNameTB.Name = "customerNameTB";
            this.customerNameTB.Size = new System.Drawing.Size(200, 39);
            this.customerNameTB.TabIndex = 4;
            // 
            // customerPhoneLabel
            // 
            this.customerPhoneLabel.AutoSize = true;
            this.customerPhoneLabel.Location = new System.Drawing.Point(410, 328);
            this.customerPhoneLabel.Name = "customerPhoneLabel";
            this.customerPhoneLabel.Size = new System.Drawing.Size(82, 32);
            this.customerPhoneLabel.TabIndex = 5;
            this.customerPhoneLabel.Text = "Phone";
            // 
            // customerPhoneTB
            // 
            this.customerPhoneTB.Location = new System.Drawing.Point(410, 363);
            this.customerPhoneTB.Name = "customerPhoneTB";
            this.customerPhoneTB.Size = new System.Drawing.Size(200, 39);
            this.customerPhoneTB.TabIndex = 6;
            // 
            // customerEmailTB
            // 
            this.customerEmailTB.Location = new System.Drawing.Point(410, 450);
            this.customerEmailTB.Name = "customerEmailTB";
            this.customerEmailTB.Size = new System.Drawing.Size(200, 39);
            this.customerEmailTB.TabIndex = 7;
            // 
            // customerEmailLabel
            // 
            this.customerEmailLabel.AutoSize = true;
            this.customerEmailLabel.Location = new System.Drawing.Point(410, 415);
            this.customerEmailLabel.Name = "customerEmailLabel";
            this.customerEmailLabel.Size = new System.Drawing.Size(71, 32);
            this.customerEmailLabel.TabIndex = 8;
            this.customerEmailLabel.Text = "Email";
            // 
            // createNewCustomerBtn
            // 
            this.createNewCustomerBtn.Location = new System.Drawing.Point(70, 719);
            this.createNewCustomerBtn.Name = "createNewCustomerBtn";
            this.createNewCustomerBtn.Size = new System.Drawing.Size(303, 78);
            this.createNewCustomerBtn.TabIndex = 9;
            this.createNewCustomerBtn.Text = "Create new customer";
            this.createNewCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // updateCustomerBtn
            // 
            this.updateCustomerBtn.Location = new System.Drawing.Point(410, 507);
            this.updateCustomerBtn.Name = "updateCustomerBtn";
            this.updateCustomerBtn.Size = new System.Drawing.Size(200, 46);
            this.updateCustomerBtn.TabIndex = 10;
            this.updateCustomerBtn.Text = "Update";
            this.updateCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // customerActiveRBtn
            // 
            this.customerActiveRBtn.AutoSize = true;
            this.customerActiveRBtn.Location = new System.Drawing.Point(1299, 140);
            this.customerActiveRBtn.Name = "customerActiveRBtn";
            this.customerActiveRBtn.Size = new System.Drawing.Size(215, 36);
            this.customerActiveRBtn.TabIndex = 11;
            this.customerActiveRBtn.TabStop = true;
            this.customerActiveRBtn.Text = "All active orders";
            this.customerActiveRBtn.UseVisualStyleBackColor = true;
            // 
            // customerArchivedRBtn
            // 
            this.customerArchivedRBtn.AutoSize = true;
            this.customerArchivedRBtn.Location = new System.Drawing.Point(1299, 182);
            this.customerArchivedRBtn.Name = "customerArchivedRBtn";
            this.customerArchivedRBtn.Size = new System.Drawing.Size(243, 36);
            this.customerArchivedRBtn.TabIndex = 12;
            this.customerArchivedRBtn.TabStop = true;
            this.customerArchivedRBtn.Text = "All archived orders";
            this.customerArchivedRBtn.UseVisualStyleBackColor = true;
            // 
            // customerOrderListLB
            // 
            this.customerOrderListLB.FormattingEnabled = true;
            this.customerOrderListLB.ItemHeight = 32;
            this.customerOrderListLB.Location = new System.Drawing.Point(961, 121);
            this.customerOrderListLB.Name = "customerOrderListLB";
            this.customerOrderListLB.Size = new System.Drawing.Size(303, 676);
            this.customerOrderListLB.TabIndex = 13;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 1066);
            this.Controls.Add(this.customerOrderListLB);
            this.Controls.Add(this.customerArchivedRBtn);
            this.Controls.Add(this.customerActiveRBtn);
            this.Controls.Add(this.updateCustomerBtn);
            this.Controls.Add(this.createNewCustomerBtn);
            this.Controls.Add(this.customerEmailLabel);
            this.Controls.Add(this.customerEmailTB);
            this.Controls.Add(this.customerPhoneTB);
            this.Controls.Add(this.customerPhoneLabel);
            this.Controls.Add(this.customerNameTB);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerNumberTB);
            this.Controls.Add(this.customerNumberLabel);
            this.Controls.Add(this.customerListLB);
            this.Name = "CustomerForm";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox customerListLB;
        private System.Windows.Forms.Label customerNumberLabel;
        private System.Windows.Forms.TextBox customerNumberTB;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTB;
        private System.Windows.Forms.Label customerPhoneLabel;
        private System.Windows.Forms.TextBox customerPhoneTB;
        private System.Windows.Forms.TextBox customerEmailTB;
        private System.Windows.Forms.Label customerEmailLabel;
        private System.Windows.Forms.Button createNewCustomerBtn;
        private System.Windows.Forms.Button updateCustomerBtn;
        private System.Windows.Forms.RadioButton customerActiveRBtn;
        private System.Windows.Forms.RadioButton customerArchivedRBtn;
        private System.Windows.Forms.ListBox customerOrderListLB;
    }
}