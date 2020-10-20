using System.IO;
using System.Text.Json;
using System.Threading;
using System.Windows.Forms;

namespace OOP2_Project_EA3
{
    public partial class WareHouseForm : Form
    {
        // Tre knappar, en till kunder, en till orders och en till produkter
        private Warehouse Warehouse;

        public WareHouseForm(Warehouse warehouse)
        {
            Warehouse = warehouse;
            InitializeComponent();
            

            //Watch for new orders in .\neworders
            WatchNewOrders();
        }

        private void WatchNewOrders()
        {
            Directory.CreateDirectory("neworders");
            FileSystemWatcher fsw = new FileSystemWatcher(".\\neworders", "*.json");
            fsw.SynchronizingObject = this;
            fsw.Created += Fsw_Created;
        }

        private void Fsw_Created(object sender, FileSystemEventArgs e)
        {
            Thread.Sleep(500);
            string json = File.ReadAllText(e.FullPath);
            Order o = JsonSerializer.Deserialize<Order>(json);
            Warehouse.Orders.Add(o);
            File.Delete(e.FullPath);
        }

        private void ordersBtn_Click(object sender, System.EventArgs e)
        {
            Form orders = new OrdersForm(Warehouse);
            orders.Show();
        }

        private void customersBtn_Click(object sender, System.EventArgs e)
        {
            Form customers = new CustomersForm(Warehouse);
            customers.Show();
        }

        private void productsBtn_Click(object sender, System.EventArgs e)
        {
            Form products = new ProductsForm(Warehouse);
            products.Show();
        }
    }
}