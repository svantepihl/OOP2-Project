using System.ComponentModel;
using System.Windows.Forms;

namespace OOP2_Project_EA3
{
    partial class WareHouseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.ordersBtn.Location = new System.Drawing.Point(88, 132);
            this.ordersBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Size = new System.Drawing.Size(185, 67);
            this.ordersBtn.TabIndex = 0;
            this.ordersBtn.Text = "Orders";
            this.ordersBtn.UseVisualStyleBackColor = true;
            this.ordersBtn.Click += new System.EventHandler(this.ordersBtn_Click);
            // 
            // customersBtn
            // 
            this.customersBtn.Location = new System.Drawing.Point(287, 132);
            this.customersBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Size = new System.Drawing.Size(185, 67);
            this.customersBtn.TabIndex = 1;
            this.customersBtn.Text = "Customers";
            this.customersBtn.UseVisualStyleBackColor = true;
            this.customersBtn.Click += new System.EventHandler(this.customersBtn_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.Location = new System.Drawing.Point(486, 132);
            this.productsBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(185, 67);
            this.productsBtn.TabIndex = 2;
            this.productsBtn.Text = "Products";
            this.productsBtn.UseVisualStyleBackColor = true;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // WareHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 331);
            this.Controls.Add(this.productsBtn);
            this.Controls.Add(this.customersBtn);
            this.Controls.Add(this.ordersBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "WareHouseForm";
            this.Text = "Warehouse management";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ordersBtn;
        private Button customersBtn;
        private Button productsBtn;
    }
}