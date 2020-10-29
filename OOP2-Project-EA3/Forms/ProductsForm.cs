using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace OOP2_Project_EA3
{
    public partial class ProductsForm : Form
    {
        private readonly Warehouse _warehouse;
        public ProductsForm(Warehouse warehouse)
        {
            _warehouse = warehouse;
            InitializeComponent();
            _warehouse.Products.CatalogueChanged += Products_CatalogueChanged;
            GetProducts();
        }


        private void createNewProductBtn_Click(object sender, EventArgs e)
        {
            CreateProductForm createProductForm = new CreateProductForm(_warehouse);
            createProductForm.Show();
            _warehouse.Products.CatalogueChanged += Products_CatalogueChanged;
        }

        private void Products_CatalogueChanged(object sender, EventArgs e)
        {
            GetProducts();
        }

        private void GetProducts()
        {
            productListLB.Items.Clear();
            productStockZeroListLB.Items.Clear();
            List<Product> allProducts = _warehouse.Products.GetAll().ToList();
            foreach (Product product in allProducts)
            {
                productListLB.Items.Add(product);
                if (product.Stock == 0)
                {
                    productStockZeroListLB.Items.Add(product);
                }
            }


            try
            {
                nearestDateLabel.Text = allProducts.Min(x => x.NextStocking).ToShortDateString();
            }
            catch (Exception)
            {
                nearestDateLabel.Text = "N/A";
            }

            


        }

        private void productListLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product temp = productListLB.SelectedItem as Product;
            if (temp != null)
            {
                productPriceTB.Text = temp.Price.ToString(CultureInfo.InvariantCulture);
                productCodeTB.Text = temp.Code.ToString();
                productNameTB.Text = temp.Name;
                productStockTB.Text = temp.Stock.ToString();
                availableDatePicker.Text = temp.Firstavailable.ToShortDateString();
                restockDatePicker.Text = temp.NextStocking.ToShortDateString();
            }
        }

        private void updateProductBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(productCodeTB.Text))
            {
                try
                {
                    Product current = _warehouse.Products.Find(int.Parse(productCodeTB.Text));
                    Product updated = new Product
                    {
                        Name = productNameTB.Text,
                        Code = Int32.Parse(productCodeTB.Text),
                        Price = double.Parse(productPriceTB.Text),
                        Stock = Int32.Parse(productStockTB.Text),
                        Firstavailable = DateTime.Parse(availableDatePicker.Text),
                        NextStocking = DateTime.Parse(restockDatePicker.Text)
                    };
                    if (_warehouse.Products.Update(current, updated))
                    {
                        MessageBox.Show("Product" + updated.Name + " was successfully updated!");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("No customer is currently selected!");
            }
        }

        // TODO: Lägga till produkt till katalogen,
        // Ändra produktinformation, visa alla produkter, visa datum för nästa restocking
        // Kommer antagligen behöva någon sorts lista för att spara produkter.
    }
}
