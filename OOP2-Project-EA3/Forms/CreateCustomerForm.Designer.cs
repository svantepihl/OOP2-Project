namespace OOP2_Project_EA3
{
    partial class CreateCustomerForm
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
            this.customerNumberLabel = new System.Windows.Forms.Label();
            this.customerEmailLabel = new System.Windows.Forms.Label();
            this.customerEmailTB = new System.Windows.Forms.TextBox();
            this.customerPhoneTB = new System.Windows.Forms.TextBox();
            this.customerPhoneLabel = new System.Windows.Forms.Label();
            this.customerNameTB = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNumberTB = new System.Windows.Forms.TextBox();
            this.createCustomerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerNumberLabel
            // 
            this.customerNumberLabel.AutoSize = true;
            this.customerNumberLabel.Location = new System.Drawing.Point(51, 89);
            this.customerNumberLabel.Name = "customerNumberLabel";
            this.customerNumberLabel.Size = new System.Drawing.Size(208, 32);
            this.customerNumberLabel.TabIndex = 1;
            this.customerNumberLabel.Text = "Customer number";
            // 
            // customerEmailLabel
            // 
            this.customerEmailLabel.AutoSize = true;
            this.customerEmailLabel.Location = new System.Drawing.Point(51, 360);
            this.customerEmailLabel.Name = "customerEmailLabel";
            this.customerEmailLabel.Size = new System.Drawing.Size(71, 32);
            this.customerEmailLabel.TabIndex = 8;
            this.customerEmailLabel.Text = "Email";
            // 
            // customerEmailTB
            // 
            this.customerEmailTB.Location = new System.Drawing.Point(51, 395);
            this.customerEmailTB.Name = "customerEmailTB";
            this.customerEmailTB.Size = new System.Drawing.Size(200, 39);
            this.customerEmailTB.TabIndex = 7;
            // 
            // customerPhoneTB
            // 
            this.customerPhoneTB.Location = new System.Drawing.Point(51, 308);
            this.customerPhoneTB.Name = "customerPhoneTB";
            this.customerPhoneTB.Size = new System.Drawing.Size(200, 39);
            this.customerPhoneTB.TabIndex = 6;
            // 
            // customerPhoneLabel
            // 
            this.customerPhoneLabel.AutoSize = true;
            this.customerPhoneLabel.Location = new System.Drawing.Point(51, 273);
            this.customerPhoneLabel.Name = "customerPhoneLabel";
            this.customerPhoneLabel.Size = new System.Drawing.Size(173, 32);
            this.customerPhoneLabel.TabIndex = 5;
            this.customerPhoneLabel.Text = "Phone number";
            // 
            // customerNameTB
            // 
            this.customerNameTB.Location = new System.Drawing.Point(51, 214);
            this.customerNameTB.Name = "customerNameTB";
            this.customerNameTB.Size = new System.Drawing.Size(200, 39);
            this.customerNameTB.TabIndex = 4;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(51, 178);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(78, 32);
            this.customerNameLabel.TabIndex = 3;
            this.customerNameLabel.Text = "Name";
            // 
            // customerNumberTB
            // 
            this.customerNumberTB.Location = new System.Drawing.Point(51, 124);
            this.customerNumberTB.Name = "customerNumberTB";
            this.customerNumberTB.Size = new System.Drawing.Size(200, 39);
            this.customerNumberTB.TabIndex = 2;
            // 
            // createCustomerBtn
            // 
            this.createCustomerBtn.Location = new System.Drawing.Point(51, 454);
            this.createCustomerBtn.Name = "createCustomerBtn";
            this.createCustomerBtn.Size = new System.Drawing.Size(200, 77);
            this.createCustomerBtn.TabIndex = 15;
            this.createCustomerBtn.Text = "Create customer";
            this.createCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // CreateCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 623);
            this.Controls.Add(this.createCustomerBtn);
            this.Controls.Add(this.customerNumberTB);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerNameTB);
            this.Controls.Add(this.customerPhoneLabel);
            this.Controls.Add(this.customerPhoneTB);
            this.Controls.Add(this.customerEmailTB);
            this.Controls.Add(this.customerEmailLabel);
            this.Controls.Add(this.customerNumberLabel);
            this.Name = "CreateCustomerForm";
            this.Text = "CreateCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNumberLabel;
        private System.Windows.Forms.Label customerEmailLabel;
        private System.Windows.Forms.TextBox customerEmailTB;
        private System.Windows.Forms.TextBox customerPhoneTB;
        private System.Windows.Forms.Label customerPhoneLabel;
        private System.Windows.Forms.TextBox customerNameTB;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNumberTB;
        private System.Windows.Forms.Button createCustomerBtn;
    }
}