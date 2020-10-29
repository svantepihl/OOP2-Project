using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Windows.Forms;

namespace OOP2_Project_EA3
{
    public partial class WareHouseForm : Form
    {
        // Tre knappar, en till kunder, en till orders och en till produkter
        private Warehouse _warehouse;
        private FileSystemWatcher _fsw;

        public WareHouseForm(Warehouse warehouse)
        {
            _warehouse = warehouse;
            InitializeComponent();


            //Watch for new orders in .\neworders
            WatchNewOrders();
        }

        private void WatchNewOrders()
        {
            Directory.CreateDirectory("neworders");
            _fsw = new FileSystemWatcher("./neworders", "*.json");
            _fsw.EnableRaisingEvents = true;
            _fsw.SynchronizingObject = this;
            _fsw.Created += Fsw_Created;
        }

        private void Fsw_Created(object sender, FileSystemEventArgs e)
        {
            Thread.Sleep(500);
            string json = File.ReadAllText(e.FullPath);
            Order o = JsonSerializer.Deserialize<Order>(json);

            // Kolla att order numret inte redan finns i orderkatalogen
            if (!_warehouse.Orders.GetAll().Any(x => x.Number == o.Number))
            {
                try
                {
                    // Kolla att kunden finns & ersätt med referens från kundkatalogen
                    o.Customer = _warehouse.Customers.Find(o.Customer.Number);
                    foreach (var orderLine in o.Items)
                    {
                        // För alla orderlines kolla att produkten finns & ersätt med referens från produktkatalog
                        orderLine.Product = _warehouse.Products.Find(orderLine.Product.Code);
                    }
                    _warehouse.Orders.Add(o);
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Was not able to add order from JSON-file, file has been removed, please try again!");
                    File.Delete(e.FullPath);
                }
            }

            
            File.Delete(e.FullPath);
            MessageBox.Show("A new order was added to the system!");
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            Form orders = new OrdersForm(_warehouse);
            orders.Show();
        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            Form customers = new CustomersForm(_warehouse);
            customers.Show();
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            Form products = new ProductsForm(_warehouse);
            products.Show();
        }
    }
}