using System.Windows.Forms;

namespace OOP2_Project_EA3
{
    public partial class ProductsForm : Form
    {
        private Warehouse _warehouse;
        public ProductsForm(Warehouse warehouse)
        {
            _warehouse = warehouse;
            InitializeComponent();
        }

        private void createNewProductBtn_Click(object sender, System.EventArgs e)
        {
            CreateProductForm createProductForm = new CreateProductForm(_warehouse);
            createProductForm.Show();
        }

        // TODO: Lägga till produkt till katalogen,
        // Ändra produktinformation, visa alla produkter, visa datum för nästa restocking
        // Kommer antagligen behöva någon sorts lista för att spara produkter.
    }
}
