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
        }
    }
}
