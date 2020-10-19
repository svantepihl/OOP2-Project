using System.Windows.Forms;

namespace OOP2_Project_EA3
{
    public partial class ProductForm : Form
    {
        public ProductForm(Warehouse warehouse)
        {
            InitializeComponent();
        }

        private void createNewProductBtn_Click(object sender, System.EventArgs e)
        {
            CreateProductForm createProductForm = new CreateProductForm();
            createProductForm.Show();
        }

        // TODO: Lägga till produkt till katalogen,
        // Ändra produktinformation, visa alla produkter, visa datum för nästa restocking
        // Kommer antagligen behöva någon sorts lista för att spara produkter.
    }
}
