using System.Windows.Forms;

namespace OOP2_Project_EA3
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void createNewCustomerBtn_Click(object sender, System.EventArgs e)
        {
            CreateCustomerForm createCustomerForm = new CreateCustomerForm();
            createCustomerForm.Show();
        }

        // TODO: Lägga till nya kunder, updatera kundinformation, visa alla ark
    }
}
