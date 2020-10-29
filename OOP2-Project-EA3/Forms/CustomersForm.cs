using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OOP2_Project_EA3
{
    public partial class CustomersForm : Form
    {
        private readonly Warehouse _warehouse;
        public CustomersForm(Warehouse warehouse)
        {
            _warehouse = warehouse;
            InitializeComponent();
            _warehouse.Customers.CatalogueChanged += Customers_CatalogueChanged;


/*          TESTAR
 
            Customer mathilda = _warehouse.Customers.GetAll().Single(x=>x.Number == 0);
            
            // Ska vara aktiv
            Order test = new Order();
            test.Customer = mathilda;
            test.Number = 0;
            test.Dispatched = false;
            test.OrderDate = DateTime.Now;
            _warehouse.Orders.Add(test);

            // Ska vara aktiv
            Order test2 = new Order();
            test2.Customer = mathilda;
            test2.Number = 1;
            test2.Dispatched = true;
            test2.OrderDate = DateTime.Now;
            _warehouse.Orders.Add(test2);

            // Ska vara arkiverad
            Order test3 = new Order();
            test3.Customer = mathilda;
            test3.Number = 2;
            test3.Dispatched = true;
            test3.OrderDate = DateTime.Now.AddYears(-1);
            _warehouse.Orders.Add(test3);

            // Ska vara aktiv
            Order test4 = new Order();
            test4.Customer = mathilda;
            test4.Number = 3;
            test4.Dispatched = false;
            test4.OrderDate = DateTime.Now.AddYears(-1);
            _warehouse.Orders.Add(test4);*/


            GetCustomers();
        }

        private void createNewCustomerBtn_Click(object sender, EventArgs e)
        {
            CreateCustomerForm createCustomerForm = new CreateCustomerForm(_warehouse);
            createCustomerForm.Show();
        }

        private void Customers_CatalogueChanged(object sender, EventArgs e)
        {
            GetCustomers();
        }

        private void GetCustomers()
        {
            customerListLB.Items.Clear();
            foreach (Customer customer in _warehouse.Customers.GetAll())
            {
                customerListLB.Items.Add(customer);
            }
        }

        private void customerListLB_SelectedIndexChanged(object sender, EventArgs e)
        {

                Customer temp =  customerListLB.SelectedItem as Customer;
                if (temp != null)
                {
                    customerNumberTB.Text = temp.Number.ToString();
                    customerNameTB.Text = temp.Name;
                    customerPhoneTB.Text = temp.Phone;
                    customerEmailTB.Text = temp.Email;
                    ShowCustomerOrders();
                }
        }

        private void updateCustomerBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(customerNumberTB.Text))
            {
                try
                {
                    Customer current = _warehouse.Customers.Find(int.Parse(customerNumberTB.Text));
                    Customer updated = new Customer
                    {
                        Number = int.Parse(customerNumberTB.Text),
                        Name = customerNameTB.Text,
                        Email = customerEmailTB.Text,
                        Phone = customerPhoneTB.Text
                    };
                    if (_warehouse.Customers.Update(current, updated))
                    {
                        MessageBox.Show("Customer successfully updated!");
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

        private void ShowCustomerOrders()
        {
            try
            {
                int customerNumber = Int32.Parse(customerNumberTB.Text);
                List<Order> ordersToShow = null;
                if (customerActiveRBtn.Checked)
                {
                    ordersToShow = _warehouse.Orders.GetAll().Where(x =>
                        x.Customer.Number == customerNumber &&
                        (x.Dispatched == false || x.OrderDate >= DateTime.Today.AddMonths(-1))).ToList();
                }
                else if (customerArchivedRBtn.Checked)
                {
                    ordersToShow = _warehouse.Orders.GetAll().Where(x =>
                        x.Customer.Number == customerNumber &&
                        x.Dispatched && x.OrderDate < DateTime.Today.AddMonths(-1)).ToList();
                }

                customerOrderListLB.Items.Clear();
                if (ordersToShow != null)
                {
                    foreach (Order order in ordersToShow)
                    {
                        customerOrderListLB.Items.Add(order);
                    }
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void customerActiveRBtn_CheckedChanged(object sender, EventArgs e)
        {
            ShowCustomerOrders();
        }

        private void customerArchivedRBtn_CheckedChanged(object sender, EventArgs e)
        {
            ShowCustomerOrders();
        }

        // TODO: L�gga till nya kunder, updatera kundinformation, visa alla ark
    }
}
