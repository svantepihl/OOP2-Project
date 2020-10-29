using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace OOP2_Project_EA3
{
    public partial class CreateOrderForm : Form
    {
        private Warehouse _warehouse;

        private Customer _selectedCustomer;

        private List<OrderLine> _orderlineList = new List<OrderLine>();

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
        private void ShowSelectedProducts()
        {
            selectedProductsListLB.Items.Clear();

            foreach(OrderLine o in _orderlineList)
            {
                for (int i = 0; i < o.Count; i++)
                {
                    selectedProductsListLB.Items.Add(o.Product);
                }
            }
        }
        //Select the customer
        private void selectCustomerBtn_Click(object sender, EventArgs e)
        {
            _selectedCustomer = selectCustomerListLB.SelectedItem as Customer;
            customerNameTB.Text = _selectedCustomer.Name;

        }

        private void addSelectedProductBtn_Click(object sender, EventArgs e)
        {

            OrderLine tempOrderLine = new OrderLine();
            Product temp = selectProductListLB.SelectedItem as Product;

            tempOrderLine.Product = _warehouse.Products.Find(temp.Code);
            tempOrderLine.Count = Decimal.ToInt32(selectQuantityNUD.Value);

            _orderlineList.Add(tempOrderLine);

            ShowSelectedProducts();
        }

        private void placeOrderBtn_Click(object sender, EventArgs e)
        {

            //if(selectedCustomer != null && shippingAdressTB.Text != null && orderlineList != null)?
            List<Order> allOrders = _warehouse.Orders.GetAll().ToList();
            int number;
            if(allOrders.Count == 0)
            {
                number = 1;
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
                temp.Items = new List<OrderLine>();
                temp.Number = number;
                temp.Customer = _warehouse.Customers.GetAll().Single(x=>x.Number == _selectedCustomer.Number);
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

                foreach (var orderLine in _orderlineList)
                {
                    if (temp.Items.Exists(x=> x.Product.Code == orderLine.Product.Code))
                    {
                        temp.Items.Single(x => x.Product.Code == orderLine.Product.Code).Count += orderLine.Count;
                    }
                    else
                    {
                        temp.Items.Add(orderLine);
                    }
                }
                
                _warehouse.Orders.Add(temp);
                Close();
                MessageBox.Show("Order was added succefully!" + temp.OrderDate.ToString(CultureInfo.InvariantCulture));

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
            var find = _orderlineList.FirstOrDefault(x => x.Product == temp);
            if(find != null)
            {
                --find.Count;
            

                if(find.Count < 1)
                {
                    _orderlineList.Remove(find);
                }
            }

            ShowSelectedProducts();
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
