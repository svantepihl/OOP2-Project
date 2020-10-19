using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace OOP2_Project_EA3
{
    public partial class OrdersForm : Form
    {

        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, System.EventArgs e)
        {
            
        }

        private void addNewOrderBtn_Click(object sender, System.EventArgs e)
        {
            Form CreateOrder = new CreateOrderForm();
            CreateOrder.Show();
            
        }
    }
}
