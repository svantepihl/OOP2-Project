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
            List<string> paymentFailed = new List<string>();
            List<string> notAvailible = new List<string>();
            List<string> dispatched = new List<string>();

            var paymentComplete = from order in listOfOrders
                                  where order.PaymentCompleted == true
                                  select order;

            foreach(var order in paymentComplete)
            {
                for (int i = 0; i < paymentComplete.ToList().Count; i++)
                {
                    if (!_warehouse.Products.ValidateProduct(order.Items[i].Product))
                    {
                        
                    }
                }

            }


           foreach (Order o in _warehouse.Orders.GetPendingOrders().ToList())
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
                        if(_warehouse.Products.ValidateProduct(o.Items[i].Product))
                        {
                            int stock = _warehouse.Products.GetStock(ol[i].Product.Code);

                            if (!(stock >= ol[i].Count) || o.Items[i].Product.Firstavailable > DateTime.Now)
                            {
                                check = false;
                            }
                        }
                        else
                        {
                            o.PaymentRefunded = true;
                        }
   
                    }




                        if(o.PaymentRefunded)
                        {
                            //remove order?
                            //add to message that payment was refunded for order and it has been removed
                        }
                        else if (check)
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
                            updated.DispatchDate = DateTime.Now; 

                            _warehouse.Orders.Update(o, updated);
                            dispatched.Add("#" + o.Number.ToString());
                        }
                        else
                        {
                            notAvailible.Add("#" + o.Number.ToString());
                        }


                    }
            }
            
            string paymentdenied = String.Format("Following orders cannot be dispatched because of incomplete payment: \n{0} \n", String.Join(Environment.NewLine, paymentFailed));
            string disp = String.Format("Following orders have been dispatched: \n{0} \n", String.Join(Environment.NewLine, dispatched));
            string noavailability = String.Format("Following orders can't be dispatched because of no availability: \n{0} \n", String.Join(Environment.NewLine, notAvailible));
           
            MessageBox.Show(paymentdenied + noavailability + "------------------------------\n" + disp);

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
                GetOrderLines();
            }
            
        }

        private void processOrderBtn_Click(object sender, EventArgs e)
        {
            ProcessOrders();
        }

       
    }
}
