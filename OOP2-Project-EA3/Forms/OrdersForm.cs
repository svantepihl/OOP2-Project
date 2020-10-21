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
            GetOrders();
        }


        private void GetOrders()
        {
            orderLineListLB.Items.Clear();

            List<Order> allOrders = _warehouse.Orders.GetAll().ToList();
            foreach (Order order in allOrders)
            {
                orderLineListLB.Items.Add(order.Items);
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
            }
        }

        private void pendingOrdersRBtn_CheckedChanged(object sender, System.EventArgs e)
        {
            if (dispatchedOrdersRBtn.Checked == true)
            {
                orderListLabel.Text = "Dispatched orders";
                dateLabel.Text = "Date dispatched";
            }
        }

        private void customerPendingListLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void orderLineListLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ordersListLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
