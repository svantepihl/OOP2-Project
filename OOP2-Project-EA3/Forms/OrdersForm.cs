using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

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
        private void Orders_CatalogueChanged(object sender, EventArgs e)
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

        private void OrdersForm_Load(object sender, EventArgs e)
        {
        }

        private void addNewOrderBtn_Click(object sender, EventArgs e)
        {
            CreateOrderForm createOrder = new CreateOrderForm(_warehouse);
            createOrder.Show();

        }

        private void dispatchedOrdersRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (pendingOrdersRBtn.Checked)
            {
                orderListLabel.Text = "Pending orders";
                dateLabel.Text = "Est. dispatch date";
                ShowOrders();
                GetOrderLines();
            }
        }

        private void pendingOrdersRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dispatchedOrdersRBtn.Checked)
            {
                orderListLabel.Text = "Dispatched orders";
                dateLabel.Text = "Date dispatched";
                ShowOrders();
                GetOrderLines();
            }
        }

        private void ordersListLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order selected = ordersListLB.SelectedItem as Order;
            if(selected != null)
            {
                if(pendingOrdersRBtn.Checked)
                {
                    dateTB.Text = _warehouse.EarliestDispatch(selected);
                }
                else
                {
                    dateTB.Text = selected.DispatchDate.ToString(CultureInfo.InvariantCulture);
                }
                
                customerNameTB.Text = selected.Customer.Name;
                customerEmailTB.Text = selected.Customer.Email;
                customerPhoneTB.Text = selected.Customer.Phone;
                GetOrderLines();
            }
            
        }

        private void processOrderBtn_Click(object sender, EventArgs e)
        {
           _warehouse.BatchProcessOrders();
            ShowCustomersWithOrders();
            ShowOrders();
            GetOrderLines();
        }

        

    }
}
