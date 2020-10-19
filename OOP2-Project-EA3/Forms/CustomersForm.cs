using System.Windows.Forms;

namespace OOP2_Project_EA3
{
    public partial class CustomersForm : Form
    {
        private Warehouse _warehouse;
        public CustomersForm(Warehouse warehouse)
        {
            _warehouse = warehouse;
            InitializeComponent();
        }

        private void createNewCustomerBtn_Click(object sender, System.EventArgs e)
        {
            CreateCustomerForm createCustomerForm = new CreateCustomerForm(_warehouse);
            createCustomerForm.Show();
        }

        // TODO: Lägga till nya kunder, updatera kundinformation, visa alla ark
    }
}
