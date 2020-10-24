using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.CodeDom.Compiler;

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

            Order selectedOrder = ordersListLB.SelectedItem as Order;

           if (selectedOrder != null)
            {
                for(int i = 0; i < selectedOrder.Items.Count; i++)
                {
                    orderLineListLB.Items.Add(selectedOrder.Items[i].ToString());
                }

            }
        }

        private void ProcessOrders()
        {
            List<Order> listOfOrders = _warehouse.Orders.GetPendingOrders().ToList();

            var paymentComplete = from order in listOfOrders
                                  where order.PaymentCompleted == true
                                  select order;

            foreach(var order in paymentComplete)
            {
                for (int i = 0; i < order.Items.Count; i++)
                {
                    if (!_warehouse.Products.ValidateProduct(order.Items[i].Product))
                    {
                        order.PaymentRefunded = true;
                    }
                }

            }

            var ordersNotRefunded = from order in paymentComplete
                                where order.PaymentRefunded == false
                                select order;

            bool checkStock = true;
            bool checkAvailability = true;


            foreach(var order in ordersNotRefunded)
            {
                for(int i = 0; i < order.Items.Count; i++)
                {
                    int stock = _warehouse.Products.GetStock(order.Items[i].Product.Code);

                    if(stock < order.Items[i].Count)
                    {
                        checkStock = false;
                    }
                    if(order.Items[i].Product.Firstavailable > DateTime.Now)
                    {
                        checkAvailability = false;
                    }

                }

                

                if(checkStock && checkAvailability)
                {
                    for (int i = 0; i < order.Items.Count; i++)
                    {
                        _warehouse.Products.DispatchStock(order.Items[i].Product.Code, order.Items[i].Count);
                    }

                    Order updated = new Order();

                    updated.Dispatched = true;
                    updated.Customer = order.Customer;
                    updated.DeliveryAddress = order.DeliveryAddress;
                    updated.Items = order.Items;
                    updated.PaymentCompleted = order.PaymentCompleted;
                    updated.PaymentRefunded = order.PaymentRefunded;
                    updated.Number = order.Number;
                    updated.DispatchDate = DateTime.Now;
                    updated.OrderDate = order.OrderDate;

                    _warehouse.Orders.Update(order, updated);
                }

                checkStock = true;
                checkAvailability = true;
            }
        }

        private void ShowOrders()
        {
            ordersListLB.Items.Clear();

            if(dispatchedOrdersRBtn.Checked)
            {
                foreach(var o in _warehouse.Orders.GetDispatchedOrders())
                ordersListLB.Items.Add(o);
            }
            else if(pendingOrdersRBtn.Checked)
            {
                foreach(var o in _warehouse.Orders.GetPendingOrders())
                ordersListLB.Items.Add(o);
            }        
        }

        private void ShowCustomersWithOrders()
        {   

          customerPendingListLB.Items.Clear();

            List<Order> pendingOrders = _warehouse.Orders.GetPendingOrders().ToList();

            foreach(Order o in pendingOrders)
            {
                customerPendingListLB.Items.Add("#" + o.Customer.Number + " " + o.Customer.Name + " Order:" + o.Number);
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
                if(pendingOrdersRBtn.Checked == true)
                {
                    //find the earliest date where all products can be shipped, firstavailible and nextstocking

                    dateTB.Text = _warehouse.Orders.EarliestDispatch(selected);

                }
                else
                {
                    dateTB.Text = selected.DispatchDate.ToString();
                }
                
                customerNameTB.Text = selected.Customer.Name;
                customerEmailTB.Text = selected.Customer.Email.ToString();
                customerPhoneTB.Text = selected.Customer.Phone.ToString();
                GetOrderLines();
            }
            
        }

        private void processOrderBtn_Click(object sender, EventArgs e)
        {
            ProcessOrders();
        }

        

    }
}
