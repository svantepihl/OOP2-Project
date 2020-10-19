using System.Windows.Forms;

namespace OOP2_Project_EA3
{
    public partial class CustomerForm : Form
    {
        public CustomerForm(Warehouse warehouse)
        {
            InitializeComponent();
        }

        private void createNewCustomerBtn_Click(object sender, System.EventArgs e)
        {
            Form createCustomer = new CreateCustomerForm();
            createCustomer.Show();
        }

        // TODO: Lägga till nya kunder, updatera kundinformation, visa alla ark
    }
}
