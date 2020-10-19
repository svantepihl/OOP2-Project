using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OOP2_Project_EA3
{
    public class Warehouse
    {
        public ICustomers Customers;

        public IProducts Products;

        public IOrders Orders;

        public Warehouse(string folder)
        {
            Directory.CreateDirectory(folder);
            Customers = new CustomerCatalogue(folder);
            Products = new ProductCatalogue(folder);
            Orders = new OrderCatalogue(folder);
        }
        
        /// <summary>
        /// Process all orders that are not dispatched and where payment is collected and not refunded.
        /// </summary>
        public void BatchProcessOrders()
        {
            // Adds all items where payment is made and not dispatched yet and places them in a queue based on OrderDate in ascending orders
            Queue<Order> orderQueue = new Queue<Order>(Orders.GetAll()
                .Where(x=> x.Dispatched == false && x.PaymentCompleted == true && x.PaymentRefunded == false)
                .OrderBy(x => x.OrderDate));
            
            while (orderQueue.Count > 0)
            {
                // Process the next order in the queue
                ProcessOrder(orderQueue.Dequeue());
            }
        }

        /// <summary>
        /// Processes the order given in the argument.
        /// If all products are valid and there is enough stock the order is marked as dispatched inventory is updated.
        /// </summary>
        /// <param name="order">Order to be processed</param>
        private void ProcessOrder(Order order)
        {
            // Check that all products in the order are valid products, if not refund order.
            if (order.Items.Exists(x => !Products.ValidateProduct(x.Product)))
            {
                Orders.RefundOrder(order.Number);
                return;
            }
            
            // Check that there is enough stock for all items in the order, if so update stock and mark order as dispatched.
            if (order.Items.TrueForAll(x => Products.GetStock(x.Product.Code) - x.Count < 0))
            {
                order.Items.ForEach(x=> Products.DispatchStock(x.Product.Code,x.Count));
                Orders.DispatchOrder(order.Number);
            }
        }
    }
}