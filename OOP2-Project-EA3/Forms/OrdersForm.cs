using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace OOP2_Project_EA3
{
    public partial class OrdersForm : Form
    {
        private Warehouse _warehouse;


        public OrdersForm(Warehouse warehouse)
        {
            _warehouse = warehouse;
            InitializeComponent();
            ShowOrders();
            ShowCustomersWithOrders();
            GetOrderLines();

            _warehouse.Orders.CatalogueChanged += Orders_CatalogueChanged;

        }
        private void Orders_CatalogueChanged(object sender, System.EventArgs e)
        {
            ShowOrders();
            ShowCustomersWithOrders();
            GetOrderLines();
        }

        private void GetOrderLines()
        {
            orderLineListLB.Items.Clear();

            List<Order> allOrders = _warehouse.Orders.GetAll().ToList();
            foreach (Order order in allOrders)
            {
                for(int i = 0; i < order.Items.Count; i++)
                {
                    orderLineListLB.Items.Add("#" + order.Items[i].Product.Code + " " + order.Items[i].Product.Name + " " + order.Items[i].Count);
                }
            }
        }

        private void ProcessOrders()
        {

            List<Order> allOrders = _warehouse.Orders.GetAll().ToList();
            List<OrderLine> ol = new List<OrderLine>();
            List<string> paymentFailed = new List<string>();
            List<string> notEnoughStockOrNotReleased = new List<string>();
            List<string> dispatched = new List<string>();

            foreach(Order o in allOrders)
            {
                if (!o.Dispatched)
                {
                    if (o.PaymentCompleted == false)
                    {
                        paymentFailed.Add("#" + o.Number.ToString());
                    }
                    else
                    {
                        ol = o.Items;
                        bool check = true;

                        for (int i = 0; i < o.Items.Count; i++)
                        {
                            int stock = _warehouse.Products.GetStock(ol[i].Product.Code);
                            if (!(stock >= ol[i].Count) || o.Items[i].Product.Firstavailable > DateTime.Now)
                            {
                                check = false;
                            }
                        }

                        if (check)
                        {
                            for (int i = 0; i < o.Items.Count; i++)
                            {
                                _warehouse.Products.DispatchStock(o.Items[i].Product.Code, o.Items[i].Count);
                            }

                            Order updated = new Order();

                            updated.Dispatched = true;
                            updated.Customer = o.Customer;
                            updated.DeliveryAddress = o.DeliveryAddress;
                            updated.Items = o.Items;
                            updated.PaymentCompleted = o.PaymentCompleted;
                            updated.PaymentRefunded = o.PaymentRefunded;
                            updated.Number = o.Number;
                            updated.OrderDate = o.OrderDate;

                            _warehouse.Orders.Update(o, updated);
                            dispatched.Add("#" + o.Number.ToString());
                        }
                        else
                        {
                            notEnoughStockOrNotReleased.Add("#" + o.Number.ToString());
                        }


                    }
                }
            }
            
            string paymentdenied = String.Format("Following orders cannot be dispatched because of incomplete payment: \n{0} \n", String.Join(Environment.NewLine, paymentFailed));
            string disp = String.Format("Following orders have been dispatched: \n{0} \n", String.Join(Environment.NewLine, dispatched));
            string nostockornorelease = String.Format("Following orders can't be dispatched because of no availability: \n{0} \n", String.Join(Environment.NewLine, notEnoughStockOrNotReleased));
           
            MessageBox.Show(paymentdenied + nostockornorelease + "------------------------------\n" + disp);

        }

        private void ShowOrders()
        {
            ordersListLB.Items.Clear();
            List<Order> allOrders = _warehouse.Orders.GetAll().ToList();

            foreach (Order o in allOrders)
            {
                if(o.Dispatched && dispatchedOrdersRBtn.Checked)
                {
                    ordersListLB.Items.Add(o);
                }
                else if(!o.Dispatched && pendingOrdersRBtn.Checked)
                {
                    ordersListLB.Items.Add(o);
                }
                
            }
            
        }

        private void ShowCustomersWithOrders()
        {
            customerPendingListLB.Items.Clear();

            List<Order> allOrders = _warehouse.Orders.GetAll().ToList();

            foreach(Order o in allOrders)
            {
                customerPendingListLB.Items.Add(o.Customer);
            }
        }

        private void OrdersForm_Load(object sender, System.EventArgs e)
        {
        }

        private void addNewOrderBtn_Click(object sender, System.EventArgs e)
        {
            CreateOrderForm createOrder = new CreateOrderForm(_warehouse);
            createOrder.Show();

        }

        private void dispatchedOrdersRBtn_CheckedChanged(object sender, System.EventArgs e)
        {
            if (pendingOrdersRBtn.Checked == true)
            {
                orderListLabel.Text = "Pending orders";
                dateLabel.Text = "Est. dispatch date";
                ShowOrders();
            }
        }

        private void pendingOrdersRBtn_CheckedChanged(object sender, System.EventArgs e)
        {
            if (dispatchedOrdersRBtn.Checked == true)
            {
                orderListLabel.Text = "Dispatched orders";
                dateLabel.Text = "Date dispatched";
                ShowOrders();
            }
        }

        private void ordersListLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order selected = ordersListLB.SelectedItem as Order;
            if(selected != null)
            {
                dateTB.Text = selected.OrderDate.ToString();
                customerNameTB.Text = selected.Customer.Name;
                customerEmailTB.Text = selected.Customer.Email.ToString();
                customerPhoneTB.Text = selected.Customer.Phone.ToString();
            }
            
        }

        private void processOrderBtn_Click(object sender, EventArgs e)
        {
            ProcessOrders();
        }

       
    }
}
