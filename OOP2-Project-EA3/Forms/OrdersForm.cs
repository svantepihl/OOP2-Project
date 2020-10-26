using System;
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
                customerPendingListLB.Items.Add("#" + o.Customer.Number + ":" + o.Customer.Name + ", Order#:" + o.Number);
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
                    dateTB.Text = _warehouse.EarliestDispatch(selected);
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
           _warehouse.BatchProcessOrders();
            ShowCustomersWithOrders();
            ShowOrders();
        }

        

    }
}
