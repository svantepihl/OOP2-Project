using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace OOP2_Project_EA3
{
    public partial class CreateOrderForm : Form
    {
        private Warehouse _warehouse;

        private Customer selectedCustomer;

        private List<OrderLine> orderlineList = new List<OrderLine>();

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
                for (int i = 0; i < o.Count; i++)
                {
                    selectedProductsListLB.Items.Add(o.Product);
                }
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

            //if(selectedCustomer != null && shippingAdressTB.Text != null && orderlineList != null)?
            List<Order> allOrders = _warehouse.Orders.GetAll().ToList();
            int number;
            if(allOrders.Count == 0)
            {
                number = 0;
            }
            else
            {
                int index = allOrders.Count - 1;
                Order lastorder = allOrders[index];
                number = lastorder.Number + 1;
            }
            try
            {
                Order temp = new Order();
                temp.Number = number;
                temp.Customer = selectedCustomer;
                temp.DeliveryAddress = shippingAdressTB.Text;
                temp.OrderDate = DateTime.Now;
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
            Product temp = selectedProductsListLB.SelectedItem as Product;
            var find = orderlineList.FirstOrDefault(x => x.Product == temp);
            if(find != null)
            {
                --find.Count;
            }

            if(find.Count < 1)
            {
                orderlineList.Remove(find);
            }

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
