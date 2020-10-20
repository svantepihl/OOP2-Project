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
    }
}
