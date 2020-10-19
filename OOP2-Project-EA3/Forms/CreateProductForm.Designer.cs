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
            this.productAvailableTB = new System.Windows.Forms.TextBox();
            this.productStockLabel = new System.Windows.Forms.Label();
            this.productStockTB = new System.Windows.Forms.TextBox();
            this.productPriceTB = new System.Windows.Forms.TextBox();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productStockingTB = new System.Windows.Forms.TextBox();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.productCodeTB = new System.Windows.Forms.TextBox();
            this.createProductBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productNameTB
            // 
            this.productNameTB.Location = new System.Drawing.Point(39, 173);
            this.productNameTB.Name = "productNameTB";
            this.productNameTB.Size = new System.Drawing.Size(200, 39);
            this.productNameTB.TabIndex = 4;
            // 
            // productStockingLabel
            // 
            this.productStockingLabel.AutoSize = true;
            this.productStockingLabel.Location = new System.Drawing.Point(39, 506);
            this.productStockingLabel.Name = "productStockingLabel";
            this.productStockingLabel.Size = new System.Drawing.Size(160, 32);
            this.productStockingLabel.TabIndex = 13;
            this.productStockingLabel.Text = "Next stocking";
            // 
            // productAvilableLabel
            // 
            this.productAvilableLabel.AutoSize = true;
            this.productAvilableLabel.Location = new System.Drawing.Point(39, 413);
            this.productAvilableLabel.Name = "productAvilableLabel";
            this.productAvilableLabel.Size = new System.Drawing.Size(158, 32);
            this.productAvilableLabel.TabIndex = 12;
            this.productAvilableLabel.Text = "First available";
            // 
            // productAvailableTB
            // 
            this.productAvailableTB.Location = new System.Drawing.Point(39, 448);
            this.productAvailableTB.Name = "productAvailableTB";
            this.productAvailableTB.Size = new System.Drawing.Size(200, 39);
            this.productAvailableTB.TabIndex = 11;
            // 
            // productStockLabel
            // 
            this.productStockLabel.AutoSize = true;
            this.productStockLabel.Location = new System.Drawing.Point(39, 319);
            this.productStockLabel.Name = "productStockLabel";
            this.productStockLabel.Size = new System.Drawing.Size(71, 32);
            this.productStockLabel.TabIndex = 8;
            this.productStockLabel.Text = "Stock";
            // 
            // productStockTB
            // 
            this.productStockTB.Location = new System.Drawing.Point(39, 354);
            this.productStockTB.Name = "productStockTB";
            this.productStockTB.Size = new System.Drawing.Size(200, 39);
            this.productStockTB.TabIndex = 7;
            // 
            // productPriceTB
            // 
            this.productPriceTB.Location = new System.Drawing.Point(39, 267);
            this.productPriceTB.Name = "productPriceTB";
            this.productPriceTB.Size = new System.Drawing.Size(200, 39);
            this.productPriceTB.TabIndex = 6;
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(39, 232);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(65, 32);
            this.productPriceLabel.TabIndex = 5;
            this.productPriceLabel.Text = "Price";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(39, 137);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(78, 32);
            this.productNameLabel.TabIndex = 3;
            this.productNameLabel.Text = "Name";
            // 
            // productStockingTB
            // 
            this.productStockingTB.Location = new System.Drawing.Point(39, 542);
            this.productStockingTB.Name = "productStockingTB";
            this.productStockingTB.Size = new System.Drawing.Size(200, 39);
            this.productStockingTB.TabIndex = 14;
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Location = new System.Drawing.Point(39, 48);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(70, 32);
            this.productCodeLabel.TabIndex = 1;
            this.productCodeLabel.Text = "Code";
            // 
            // productCodeTB
            // 
            this.productCodeTB.Location = new System.Drawing.Point(39, 83);
            this.productCodeTB.Name = "productCodeTB";
            this.productCodeTB.Size = new System.Drawing.Size(200, 39);
            this.productCodeTB.TabIndex = 2;
            // 
            // createProductBtn
            // 
            this.createProductBtn.Location = new System.Drawing.Point(39, 602);
            this.createProductBtn.Name = "createProductBtn";
            this.createProductBtn.Size = new System.Drawing.Size(200, 77);
            this.createProductBtn.TabIndex = 15;
            this.createProductBtn.Text = "Create product";
            this.createProductBtn.UseVisualStyleBackColor = true;
            // 
            // CreateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 712);
            this.Controls.Add(this.createProductBtn);
            this.Controls.Add(this.productCodeTB);
            this.Controls.Add(this.productCodeLabel);
            this.Controls.Add(this.productStockingTB);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productPriceTB);
            this.Controls.Add(this.productStockTB);
            this.Controls.Add(this.productStockLabel);
            this.Controls.Add(this.productAvailableTB);
            this.Controls.Add(this.productAvilableLabel);
            this.Controls.Add(this.productStockingLabel);
            this.Controls.Add(this.productNameTB);
            this.Name = "CreateProductForm";
            this.Text = "CreateProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productNameTB;
        private System.Windows.Forms.Label productStockingLabel;
        private System.Windows.Forms.Label productAvilableLabel;
        private System.Windows.Forms.TextBox productAvailableTB;
        private System.Windows.Forms.Label productStockLabel;
        private System.Windows.Forms.TextBox productStockTB;
        private System.Windows.Forms.TextBox productPriceTB;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productStockingTB;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.TextBox productCodeTB;
        private System.Windows.Forms.Button createProductBtn;
    }
}