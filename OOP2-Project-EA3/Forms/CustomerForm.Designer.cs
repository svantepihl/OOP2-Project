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
            this.customerListLB.ItemHeight = 15;
            this.customerListLB.Location = new System.Drawing.Point(38, 57);
            this.customerListLB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.customerListLB.Name = "customerListLB";
            this.customerListLB.Size = new System.Drawing.Size(165, 274);
            this.customerListLB.TabIndex = 0;
            // 
            // customerNumberLabel
            // 
            this.customerNumberLabel.AutoSize = true;
            this.customerNumberLabel.Location = new System.Drawing.Point(221, 68);
            this.customerNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNumberLabel.Name = "customerNumberLabel";
            this.customerNumberLabel.Size = new System.Drawing.Size(104, 15);
            this.customerNumberLabel.TabIndex = 1;
            this.customerNumberLabel.Text = "Customer number";
            // 
            // customerNumberTB
            // 
            this.customerNumberTB.Location = new System.Drawing.Point(221, 84);
            this.customerNumberTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.customerNumberTB.Name = "customerNumberTB";
            this.customerNumberTB.Size = new System.Drawing.Size(110, 23);
            this.customerNumberTB.TabIndex = 2;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(221, 109);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(39, 15);
            this.customerNameLabel.TabIndex = 3;
            this.customerNameLabel.Text = "Name";
            // 
            // customerNameTB
            // 
            this.customerNameTB.Location = new System.Drawing.Point(221, 126);
            this.customerNameTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.customerNameTB.Name = "customerNameTB";
            this.customerNameTB.Size = new System.Drawing.Size(110, 23);
            this.customerNameTB.TabIndex = 4;
            // 
            // customerPhoneLabel
            // 
            this.customerPhoneLabel.AutoSize = true;
            this.customerPhoneLabel.Location = new System.Drawing.Point(221, 154);
            this.customerPhoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerPhoneLabel.Name = "customerPhoneLabel";
            this.customerPhoneLabel.Size = new System.Drawing.Size(86, 15);
            this.customerPhoneLabel.TabIndex = 5;
            this.customerPhoneLabel.Text = "Phone number";
            // 
            // customerPhoneTB
            // 
            this.customerPhoneTB.Location = new System.Drawing.Point(221, 170);
            this.customerPhoneTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.customerPhoneTB.Name = "customerPhoneTB";
            this.customerPhoneTB.Size = new System.Drawing.Size(110, 23);
            this.customerPhoneTB.TabIndex = 6;
            // 
            // customerEmailTB
            // 
            this.customerEmailTB.Location = new System.Drawing.Point(221, 211);
            this.customerEmailTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.customerEmailTB.Name = "customerEmailTB";
            this.customerEmailTB.Size = new System.Drawing.Size(110, 23);
            this.customerEmailTB.TabIndex = 7;
            // 
            // customerEmailLabel
            // 
            this.customerEmailLabel.AutoSize = true;
            this.customerEmailLabel.Location = new System.Drawing.Point(221, 195);
            this.customerEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerEmailLabel.Name = "customerEmailLabel";
            this.customerEmailLabel.Size = new System.Drawing.Size(36, 15);
            this.customerEmailLabel.TabIndex = 8;
            this.customerEmailLabel.Text = "Email";
            // 
            // createNewCustomerBtn
            // 
            this.createNewCustomerBtn.Location = new System.Drawing.Point(38, 337);
            this.createNewCustomerBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.createNewCustomerBtn.Name = "createNewCustomerBtn";
            this.createNewCustomerBtn.Size = new System.Drawing.Size(163, 37);
            this.createNewCustomerBtn.TabIndex = 9;
            this.createNewCustomerBtn.Text = "Create new customer";
            this.createNewCustomerBtn.UseVisualStyleBackColor = true;
            this.createNewCustomerBtn.Click += new System.EventHandler(this.createNewCustomerBtn_Click);
            // 
            // updateCustomerBtn
            // 
            this.updateCustomerBtn.Location = new System.Drawing.Point(221, 238);
            this.updateCustomerBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.updateCustomerBtn.Name = "updateCustomerBtn";
            this.updateCustomerBtn.Size = new System.Drawing.Size(108, 22);
            this.updateCustomerBtn.TabIndex = 10;
            this.updateCustomerBtn.Text = "Update";
            this.updateCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // customerActiveRBtn
            // 
            this.customerActiveRBtn.AutoSize = true;
            this.customerActiveRBtn.Location = new System.Drawing.Point(699, 66);
            this.customerActiveRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.customerActiveRBtn.Name = "customerActiveRBtn";
            this.customerActiveRBtn.Size = new System.Drawing.Size(109, 19);
            this.customerActiveRBtn.TabIndex = 11;
            this.customerActiveRBtn.TabStop = true;
            this.customerActiveRBtn.Text = "All active orders";
            this.customerActiveRBtn.UseVisualStyleBackColor = true;
            // 
            // customerArchivedRBtn
            // 
            this.customerArchivedRBtn.AutoSize = true;
            this.customerArchivedRBtn.Location = new System.Drawing.Point(699, 85);
            this.customerArchivedRBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.customerArchivedRBtn.Name = "customerArchivedRBtn";
            this.customerArchivedRBtn.Size = new System.Drawing.Size(123, 19);
            this.customerArchivedRBtn.TabIndex = 12;
            this.customerArchivedRBtn.TabStop = true;
            this.customerArchivedRBtn.Text = "All archived orders";
            this.customerArchivedRBtn.UseVisualStyleBackColor = true;
            // 
            // customerOrderListLB
            // 
            this.customerOrderListLB.FormattingEnabled = true;
            this.customerOrderListLB.ItemHeight = 15;
            this.customerOrderListLB.Location = new System.Drawing.Point(517, 57);
            this.customerOrderListLB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.customerOrderListLB.Name = "customerOrderListLB";
            this.customerOrderListLB.Size = new System.Drawing.Size(165, 319);
            this.customerOrderListLB.TabIndex = 13;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 500);
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
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
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