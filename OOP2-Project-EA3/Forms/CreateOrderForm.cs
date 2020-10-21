using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;


namespace OOP2_Project_EA3
{
    public partial class CreateOrderForm : Form
    {
        private Warehouse _warehouse;

        private Customer selectedCustomer;

        private List<OrderLine> orderlineList = new List<OrderLine>();

        private Order order = new Order();

        public CreateOrderForm(Warehouse warehouse)
        {
            _warehouse = warehouse;
            InitializeComponent();
            GetCustomers();
            GetProducts();
        }

        //Function to show all customers
        private void GetCustomers()
        {
            selectCustomerListLB.Items.Clear();
            foreach (Customer customer in _warehouse.Customers.GetAll())
            {
                selectCustomerListLB.Items.Add(customer);
            }
        }

        //Function to show all products in catalogue
        private void GetProducts()
        {
            selectProductListLB.Items.Clear();

            List<Product> allProducts = _warehouse.Products.GetAll().ToList();
            foreach (Product product in allProducts)
            {
                selectProductListLB.Items.Add(product);
            }
        }
        //SHow all the products in the basket
        private void showSelectedProducts()
        {
            selectedProductsListLB.Items.Clear();

            foreach(OrderLine o in orderlineList)
            {
               selectedProductsListLB.Items.Add(o.Product);
            }
        }
        //Select the customer
        private void selectCustomerBtn_Click(object sender, System.EventArgs e)
        {
            selectedCustomer = selectCustomerListLB.SelectedItem as Customer;
            customerNameTB.Text = selectedCustomer.Name;

        }

        private void addSelectedProductBtn_Click(object sender, System.EventArgs e)
        {

            OrderLine tempOrderLine = new OrderLine();

            tempOrderLine.Product = selectProductListLB.SelectedItem as Product;
            tempOrderLine.Count = Decimal.ToInt32(selectQuantityNUD.Value);

            orderlineList.Add(tempOrderLine);

            showSelectedProducts();
        }

        private void placeOrderBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                Order temp = new Order();
                temp.Customer = selectedCustomer;
                temp.DeliveryAddress = shippingAdressTB.Text;
                if (orderPaidRBtn.Checked)
                {
                    temp.PaymentCompleted = true;
                }
                else
                {
                    temp.PaymentCompleted = false;
                }
               temp.Items = orderlineList;
                _warehouse.Orders.Add(temp);
                this.Close();
                MessageBox.Show("Order was added succefully!");
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void selectQuantityNUD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void removeSelectedProductBtn_Click(object sender, EventArgs e)
        {
            //if count == 0 after count-- then remove whole orderline?

            showSelectedProducts();
        }

        private void shippingAdressTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderPaidRBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void orderUnpaidRBtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
