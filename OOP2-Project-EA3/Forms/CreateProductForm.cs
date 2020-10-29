using System;
using System.Windows.Forms;

namespace OOP2_Project_EA3
{
    public partial class CreateProductForm : Form
    {
        private Warehouse _warehouse;
        public CreateProductForm(Warehouse warehouse)
        {
            _warehouse = warehouse;
            InitializeComponent();
        }

        private void createProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Product temp = new Product();
                if (!int.TryParse(productCodeTB.Text, out var tempCode))
                {
                    MessageBox.Show("Enter a valid product code!");
                }
                temp.Code = tempCode;
                temp.Name = productNameTB.Text;
                if (!double.TryParse(productPriceTB.Text, out var tempPrice))
                {
                    MessageBox.Show("Enter a valid price!");
                    return;
                } 
                temp.Price = tempPrice;
                if (!int.TryParse(productStockTB.Text,out var tempStock))
                {
                    MessageBox.Show("Enter valid amount of stock!");
                    return;
                }

                temp.Stock = tempStock;
                temp.Firstavailable = DateTime.Parse(availableDatePicker.Text);
                temp.NextStocking = DateTime.Parse(restockDatePicker.Text);
                _warehouse.Products.Add(temp);
                Close();
                MessageBox.Show("Product was added succefully!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
