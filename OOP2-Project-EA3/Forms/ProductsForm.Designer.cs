namespace OOP2_Project_EA3
{
    partial class ProductsForm
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
            this.productListLB = new System.Windows.Forms.ListBox();
            this.productCodeTB = new System.Windows.Forms.TextBox();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.productNameTB = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productPriceTB = new System.Windows.Forms.TextBox();
            this.productStockTB = new System.Windows.Forms.TextBox();
            this.productStockLabel = new System.Windows.Forms.Label();
            this.updateProductBtn = new System.Windows.Forms.Button();
            this.productAvailableLabel = new System.Windows.Forms.Label();
            this.productStockingLabel = new System.Windows.Forms.Label();
            this.productStockZeroListLB = new System.Windows.Forms.ListBox();
            this.createNewProductBtn = new System.Windows.Forms.Button();
            this.availableDatePicker = new System.Windows.Forms.DateTimePicker();
            this.restockDatePicker = new System.Windows.Forms.DateTimePicker();
            this.nextRestockLabel = new System.Windows.Forms.Label();
            this.nearestDateLabel = new System.Windows.Forms.Label();
            this.allProductsLabel = new System.Windows.Forms.Label();
            this.zeroStockProductsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productListLB
            // 
            this.productListLB.FormattingEnabled = true;
            this.productListLB.ItemHeight = 15;
            this.productListLB.Location = new System.Drawing.Point(23, 49);
            this.productListLB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.productListLB.Name = "productListLB";
            this.productListLB.Size = new System.Drawing.Size(165, 319);
            this.productListLB.TabIndex = 0;
            this.productListLB.SelectedIndexChanged += new System.EventHandler(this.productListLB_SelectedIndexChanged);
            // 
            // productCodeTB
            // 
            this.productCodeTB.Location = new System.Drawing.Point(206, 93);
            this.productCodeTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.productCodeTB.Name = "productCodeTB";
            this.productCodeTB.ReadOnly = true;
            this.productCodeTB.Size = new System.Drawing.Size(110, 23);
            this.productCodeTB.TabIndex = 2;
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Location = new System.Drawing.Point(206, 77);
            this.productCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(35, 15);
            this.productCodeLabel.TabIndex = 1;
            this.productCodeLabel.Text = "Code";
            // 
            // productNameTB
            // 
            this.productNameTB.Location = new System.Drawing.Point(206, 135);
            this.productNameTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.productNameTB.Name = "productNameTB";
            this.productNameTB.Size = new System.Drawing.Size(110, 23);
            this.productNameTB.TabIndex = 4;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(206, 118);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(39, 15);
            this.productNameLabel.TabIndex = 3;
            this.productNameLabel.Text = "Name";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(206, 163);
            this.productPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(33, 15);
            this.productPriceLabel.TabIndex = 5;
            this.productPriceLabel.Text = "Price";
            // 
            // productPriceTB
            // 
            this.productPriceTB.Location = new System.Drawing.Point(206, 179);
            this.productPriceTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.productPriceTB.Name = "productPriceTB";
            this.productPriceTB.Size = new System.Drawing.Size(110, 23);
            this.productPriceTB.TabIndex = 6;
            // 
            // productStockTB
            // 
            this.productStockTB.Location = new System.Drawing.Point(206, 220);
            this.productStockTB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.productStockTB.Name = "productStockTB";
            this.productStockTB.Size = new System.Drawing.Size(110, 23);
            this.productStockTB.TabIndex = 7;
            // 
            // productStockLabel
            // 
            this.productStockLabel.AutoSize = true;
            this.productStockLabel.Location = new System.Drawing.Point(206, 204);
            this.productStockLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productStockLabel.Name = "productStockLabel";
            this.productStockLabel.Size = new System.Drawing.Size(36, 15);
            this.productStockLabel.TabIndex = 8;
            this.productStockLabel.Text = "Stock";
            // 
            // updateProductBtn
            // 
            this.updateProductBtn.Location = new System.Drawing.Point(206, 336);
            this.updateProductBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.updateProductBtn.Name = "updateProductBtn";
            this.updateProductBtn.Size = new System.Drawing.Size(110, 30);
            this.updateProductBtn.TabIndex = 10;
            this.updateProductBtn.Text = "Update";
            this.updateProductBtn.UseVisualStyleBackColor = true;
            this.updateProductBtn.Click += new System.EventHandler(this.updateProductBtn_Click);
            // 
            // productAvailableLabel
            // 
            this.productAvailableLabel.AutoSize = true;
            this.productAvailableLabel.Location = new System.Drawing.Point(206, 248);
            this.productAvailableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productAvailableLabel.Name = "productAvailableLabel";
            this.productAvailableLabel.Size = new System.Drawing.Size(78, 15);
            this.productAvailableLabel.TabIndex = 12;
            this.productAvailableLabel.Text = "First available";
            // 
            // productStockingLabel
            // 
            this.productStockingLabel.AutoSize = true;
            this.productStockingLabel.Location = new System.Drawing.Point(206, 291);
            this.productStockingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productStockingLabel.Name = "productStockingLabel";
            this.productStockingLabel.Size = new System.Drawing.Size(80, 15);
            this.productStockingLabel.TabIndex = 13;
            this.productStockingLabel.Text = "Next stocking";
            // 
            // productStockZeroListLB
            // 
            this.productStockZeroListLB.FormattingEnabled = true;
            this.productStockZeroListLB.ItemHeight = 15;
            this.productStockZeroListLB.Location = new System.Drawing.Point(517, 49);
            this.productStockZeroListLB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.productStockZeroListLB.Name = "productStockZeroListLB";
            this.productStockZeroListLB.Size = new System.Drawing.Size(228, 319);
            this.productStockZeroListLB.TabIndex = 15;
            // 
            // createNewProductBtn
            // 
            this.createNewProductBtn.Location = new System.Drawing.Point(23, 377);
            this.createNewProductBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.createNewProductBtn.Name = "createNewProductBtn";
            this.createNewProductBtn.Size = new System.Drawing.Size(163, 37);
            this.createNewProductBtn.TabIndex = 9;
            this.createNewProductBtn.Text = "Create new product";
            this.createNewProductBtn.UseVisualStyleBackColor = true;
            this.createNewProductBtn.Click += new System.EventHandler(this.createNewProductBtn_Click);
            // 
            // availableDatePicker
            // 
            this.availableDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.availableDatePicker.Location = new System.Drawing.Point(206, 266);
            this.availableDatePicker.Name = "availableDatePicker";
            this.availableDatePicker.Size = new System.Drawing.Size(110, 23);
            this.availableDatePicker.TabIndex = 16;
            // 
            // restockDatePicker
            // 
            this.restockDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.restockDatePicker.Location = new System.Drawing.Point(206, 309);
            this.restockDatePicker.Name = "restockDatePicker";
            this.restockDatePicker.Size = new System.Drawing.Size(110, 23);
            this.restockDatePicker.TabIndex = 16;
            // 
            // nextRestockLabel
            // 
            this.nextRestockLabel.AutoSize = true;
            this.nextRestockLabel.Location = new System.Drawing.Point(206, 36);
            this.nextRestockLabel.Name = "nextRestockLabel";
            this.nextRestockLabel.Size = new System.Drawing.Size(154, 15);
            this.nextRestockLabel.TabIndex = 17;
            this.nextRestockLabel.Text = "Next restock for warehouse:";
            // 
            // nearestDateLabel
            // 
            this.nearestDateLabel.AutoSize = true;
            this.nearestDateLabel.Location = new System.Drawing.Point(206, 51);
            this.nearestDateLabel.Name = "nearestDateLabel";
            this.nearestDateLabel.Size = new System.Drawing.Size(70, 15);
            this.nearestDateLabel.TabIndex = 18;
            this.nearestDateLabel.Text = "Not defined";
            // 
            // allProductsLabel
            // 
            this.allProductsLabel.AutoSize = true;
            this.allProductsLabel.Location = new System.Drawing.Point(23, 33);
            this.allProductsLabel.Name = "allProductsLabel";
            this.allProductsLabel.Size = new System.Drawing.Size(71, 15);
            this.allProductsLabel.TabIndex = 19;
            this.allProductsLabel.Text = "All products";
            // 
            // zeroStockProductsLabel
            // 
            this.zeroStockProductsLabel.AutoSize = true;
            this.zeroStockProductsLabel.Location = new System.Drawing.Point(517, 33);
            this.zeroStockProductsLabel.Name = "zeroStockProductsLabel";
            this.zeroStockProductsLabel.Size = new System.Drawing.Size(128, 15);
            this.zeroStockProductsLabel.TabIndex = 20;
            this.zeroStockProductsLabel.Text = "Products with no stock";
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 525);
            this.Controls.Add(this.zeroStockProductsLabel);
            this.Controls.Add(this.allProductsLabel);
            this.Controls.Add(this.nearestDateLabel);
            this.Controls.Add(this.nextRestockLabel);
            this.Controls.Add(this.restockDatePicker);
            this.Controls.Add(this.availableDatePicker);
            this.Controls.Add(this.createNewProductBtn);
            this.Controls.Add(this.productStockZeroListLB);
            this.Controls.Add(this.productStockingLabel);
            this.Controls.Add(this.productAvailableLabel);
            this.Controls.Add(this.updateProductBtn);
            this.Controls.Add(this.productStockLabel);
            this.Controls.Add(this.productStockTB);
            this.Controls.Add(this.productPriceTB);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productNameTB);
            this.Controls.Add(this.productCodeLabel);
            this.Controls.Add(this.productCodeTB);
            this.Controls.Add(this.productListLB);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ProductsForm";
            this.Text = "Products";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productListLB;
        private System.Windows.Forms.TextBox productCodeTB;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.TextBox productNameTB;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.TextBox productPriceTB;
        private System.Windows.Forms.TextBox productStockTB;
        private System.Windows.Forms.Label productStockLabel;
        private System.Windows.Forms.Button updateProductBtn;
        private System.Windows.Forms.Label productAvailableLabel;
        private System.Windows.Forms.Label productStockingLabel;
        private System.Windows.Forms.ListBox productStockZeroListLB;
        private System.Windows.Forms.Button createNewProductBtn;
        private System.Windows.Forms.DateTimePicker availableDatePicker;
        private System.Windows.Forms.DateTimePicker restockDatePicker;
        private System.Windows.Forms.Label nextRestockLabel;
        private System.Windows.Forms.Label nearestDateLabel;
        private System.Windows.Forms.Label allProductsLabel;
        private System.Windows.Forms.Label zeroStockProductsLabel;
    }
}