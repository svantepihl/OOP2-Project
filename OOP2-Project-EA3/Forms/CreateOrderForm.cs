using System.Windows.Forms;

namespace OOP2_Project_EA3
{
    public partial class CreateOrderForm : Form
    {
        private Warehouse _warehouse;
        public CreateOrderForm(Warehouse warehouse)
        {
            _warehouse = warehouse;
            InitializeComponent();
            Order tmp = new Order();
            Customer cust = new Customer();
            cust.Number = 1;
            cust.Email = "test@test.se";
            cust.Phone = "123";
            cust.Name = "svante pihl";
            tmp.Customer = cust;
            _warehouse.Orders.Add(tmp);
        }
    }
}
