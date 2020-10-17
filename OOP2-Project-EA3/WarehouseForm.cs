using System.IO;
using System.Text.Json;
using System.Threading;
using System.Windows.Forms;

namespace OOP2_Project_EA3
{
    public partial class WareHouseForm : Form
    {
        // Tre knappar, en till kunder, en till orders och en till produkter
        public Warehouse Data;

        public WareHouseForm(Warehouse data)
        {
            Data = data;
            InitializeComponent();

            //Watch for new orders in ./neworders
            WatchNewOrders();
        }

        private void WatchNewOrders()
        {
            FileSystemWatcher fsw = new FileSystemWatcher("./neworders", "*.json");
            fsw.SynchronizingObject = this;
            fsw.Created += Fsw_Created;
        }

        private void Fsw_Created(object sender, FileSystemEventArgs e)
        {
            Thread.Sleep(500);
            string json = File.ReadAllText(e.FullPath);
            Order o = JsonSerializer.Deserialize<Order>(json);
            Data.Orders.Add(o);
            File.Delete(e.FullPath);
        }
    }
}