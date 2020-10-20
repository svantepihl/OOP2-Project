namespace OOP2_Project_EA3
{
    partial class CreateProductForm
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
            this.productNameTB = new System.Windows.Forms.TextBox();
            this.productStockingLabel = new System.Windows.Forms.Label();
            this.productAvilableLabel = new System.Windows.Forms.Label();
            this.productStockLabel = new System.Windows.Forms.Label();
            this.productStockTB = new System.Windows.Forms.TextBox();
            this.productPriceTB = new System.Windows.Forms.TextBox();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.productCodeTB = new System.Windows.Forms.TextBox();
            this.createProductBtn = new System.Windows.Forms.Button();
            this.availableDatePicker = new System.Windows.Forms.DateTimePicker();
            this.restockDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // productNameTB
            // 
            this.productNameTB.Location = new System.Drawing.Point(21, 81);
            this.productNameTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.productNameTB.Name = "productNameTB";
            this.productNameTB.Size = new System.Drawing.Size(189, 23);
            this.productNameTB.TabIndex = 4;
            // 
            // productStockingLabel
            // 
            this.productStockingLabel.AutoSize = true;
            this.productStockingLabel.Location = new System.Drawing.Point(21, 237);
            this.productStockingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productStockingLabel.Name = "productStockingLabel";
            this.productStockingLabel.Size = new System.Drawing.Size(80, 15);
            this.productStockingLabel.TabIndex = 13;
            this.productStockingLabel.Text = "Next stocking";
            // 
            // productAvilableLabel
            // 
            this.productAvilableLabel.AutoSize = true;
            this.productAvilableLabel.Location = new System.Drawing.Point(21, 194);
            this.productAvilableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productAvilableLabel.Name = "productAvilableLabel";
            this.productAvilableLabel.Size = new System.Drawing.Size(78, 15);
            this.productAvilableLabel.TabIndex = 12;
            this.productAvilableLabel.Text = "First available";
            // 
            // productStockLabel
            // 
            this.productStockLabel.AutoSize = true;
            this.productStockLabel.Location = new System.Drawing.Point(21, 150);
            this.productStockLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productStockLabel.Name = "productStockLabel";
            this.productStockLabel.Size = new System.Drawing.Size(36, 15);
            this.productStockLabel.TabIndex = 8;
            this.productStockLabel.Text = "Stock";
            // 
            // productStockTB
            // 
            this.productStockTB.Location = new System.Drawing.Point(21, 166);
            this.productStockTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.productStockTB.Name = "productStockTB";
            this.productStockTB.Size = new System.Drawing.Size(189, 23);
            this.productStockTB.TabIndex = 7;
            // 
            // productPriceTB
            // 
            this.productPriceTB.Location = new System.Drawing.Point(21, 125);
            this.productPriceTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.productPriceTB.Name = "productPriceTB";
            this.productPriceTB.Size = new System.Drawing.Size(189, 23);
            this.productPriceTB.TabIndex = 6;
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(21, 109);
            this.productPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(33, 15);
            this.productPriceLabel.TabIndex = 5;
            this.productPriceLabel.Text = "Price";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(21, 64);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(39, 15);
            this.productNameLabel.TabIndex = 3;
            this.productNameLabel.Text = "Name";
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Location = new System.Drawing.Point(21, 22);
            this.productCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(35, 15);
            this.productCodeLabel.TabIndex = 1;
            this.productCodeLabel.Text = "Code";
            // 
            // productCodeTB
            // 
            this.productCodeTB.Location = new System.Drawing.Point(21, 39);
            this.productCodeTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.productCodeTB.Name = "productCodeTB";
            this.productCodeTB.Size = new System.Drawing.Size(189, 23);
            this.productCodeTB.TabIndex = 2;
            // 
            // createProductBtn
            // 
            this.createProductBtn.Location = new System.Drawing.Point(21, 294);
            this.createProductBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.createProductBtn.Name = "createProductBtn";
            this.createProductBtn.Size = new System.Drawing.Size(189, 36);
            this.createProductBtn.TabIndex = 15;
            this.createProductBtn.Text = "Create product";
            this.createProductBtn.UseVisualStyleBackColor = true;
            this.createProductBtn.Click += new System.EventHandler(this.createProductBtn_Click);
            // 
            // availableDatePicker
            // 
            this.availableDatePicker.Location = new System.Drawing.Point(21, 212);
            this.availableDatePicker.Name = "availableDatePicker";
            this.availableDatePicker.Size = new System.Drawing.Size(189, 23);
            this.availableDatePicker.TabIndex = 16;
            // 
            // restockDatePicker
            // 
            this.restockDatePicker.Location = new System.Drawing.Point(21, 255);
            this.restockDatePicker.Name = "restockDatePicker";
            this.restockDatePicker.Size = new System.Drawing.Size(189, 23);
            this.restockDatePicker.TabIndex = 17;
            // 
            // CreateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 371);
            this.Controls.Add(this.restockDatePicker);
            this.Controls.Add(this.availableDatePicker);
            this.Controls.Add(this.createProductBtn);
            this.Controls.Add(this.productCodeTB);
            this.Controls.Add(this.productCodeLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productPriceTB);
            this.Controls.Add(this.productStockTB);
            this.Controls.Add(this.productStockLabel);
            this.Controls.Add(this.productAvilableLabel);
            this.Controls.Add(this.productStockingLabel);
            this.Controls.Add(this.productNameTB);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "CreateProductForm";
            this.Text = "CreateProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productNameTB;
        private System.Windows.Forms.Label productStockingLabel;
        private System.Windows.Forms.Label productAvilableLabel;
        private System.Windows.Forms.Label productStockLabel;
        private System.Windows.Forms.TextBox productStockTB;
        private System.Windows.Forms.TextBox productPriceTB;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.TextBox productCodeTB;
        private System.Windows.Forms.Button createProductBtn;
        private System.Windows.Forms.DateTimePicker availableDatePicker;
        private System.Windows.Forms.DateTimePicker restockDatePicker;
    }
}