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
                temp.Code = Int32.Parse(productCodeTB.Text);
                temp.Name = productNameTB.Text;
                temp.Price = Int32.Parse(productPriceTB.Text);
                temp.Stock = Int32.Parse(productStockTB.Text);
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
