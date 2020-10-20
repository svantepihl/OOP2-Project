using System.Runtime.CompilerServices;
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
    }
}
