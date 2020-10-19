namespace OOP2_Project_EA3
{
    partial class WareHouseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ordersBtn = new System.Windows.Forms.Button();
            this.customersBtn = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ordersBtn
            // 
            this.ordersBtn.Location = new System.Drawing.Point(163, 282);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Size = new System.Drawing.Size(344, 142);
            this.ordersBtn.TabIndex = 0;
            this.ordersBtn.Text = "Orders";
            this.ordersBtn.UseVisualStyleBackColor = true;
            // 
            // customersBtn
            // 
            this.customersBtn.Location = new System.Drawing.Point(533, 282);
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Size = new System.Drawing.Size(344, 142);
            this.customersBtn.TabIndex = 0;
            this.customersBtn.Text = "Customers";
            this.customersBtn.UseVisualStyleBackColor = true;
            // 
            // productsBtn
            // 
            this.productsBtn.Location = new System.Drawing.Point(903, 282);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(344, 142);
            this.productsBtn.TabIndex = 0;
            this.productsBtn.Text = "Products";
            this.productsBtn.UseVisualStyleBackColor = true;
            // 
            // WareHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 707);
            this.Controls.Add(this.productsBtn);
            this.Controls.Add(this.customersBtn);
            this.Controls.Add(this.ordersBtn);
            this.Name = "WareHouseForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ordersBtn;
        private System.Windows.Forms.Button customersBtn;
        private System.Windows.Forms.Button productsBtn;
    }
}