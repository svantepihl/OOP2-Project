using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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



        //// <summary>
        /// Get the earliest time an order can be dispatched
        /// </summary>
        /// <returns>Return a string with when an order can be dispatched.</returns>
        public string EarliestDispatch(Order order)
        {

            string earliestDispatchDate = "";
            List<DateTime> allReleaseDates = new List<DateTime>();
            List<DateTime> allNextStocking = new List<DateTime>();

            for (int i = 0; i < order.Items.Count; i++)
            {
                int tempCode = order.Items[i].Product.Code;

                Product tempProduct = Products.Find(tempCode);

                allReleaseDates.Add(tempProduct.Firstavailable);
            }

            var findRelease = allReleaseDates.Where(x => DateTime.Now < x);

            
            //if theres a releasedate that is later than todays date then shipment cant be made until at least then so thats the earliest estimated
            if (allReleaseDates.Where(x => DateTime.Now < x).ToList().Count > 0)
            {
                earliestDispatchDate = findRelease.Max().ToString();
            }
            else
            {
                //else check if there is no stock on some item and if not then add when the next shipment comes in
                for (int i = 0; i < order.Items.Count; i++)
                {
                    int tempCode = order.Items[i].Product.Code;

                    Product tempProduct = Products.Find(tempCode);

                    if (tempProduct.Stock < order.Items[i].Count)
                    {
                        allNextStocking.Add(order.Items[i].Product.NextStocking);
                    }
                }

                var stocking = allNextStocking.Where(o => DateTime.Now < o);

                //if there is no stock then earliest date is when that arrives, if not then check if payment is whats holding up, and if none then its ready to ship
                if (allNextStocking.Where(o => DateTime.Now < o).ToList().Count > 0)
                {
                    earliestDispatchDate = stocking.Max().ToString();
                }
                else if (order.PaymentCompleted == false)
                {
                    earliestDispatchDate = "Waiting for payment";
                }
                else
                {
                    earliestDispatchDate = "Ready";
                }
            }
            return earliestDispatchDate;
        }


        /// <summary>
        /// Process all orders that are not dispatched and where payment is collected and not refunded.
        /// </summary>
        public void BatchProcessOrders()
        {
            List<Order> listOfOrders = Orders.GetPendingOrders().ToList();
            List<int> listOfProcessed = new List<int>();

            var paymentComplete = listOfOrders.Where(o => o.PaymentCompleted == true);

            foreach (var order in paymentComplete)
            {
                for (int i = 0; i < order.Items.Count; i++)
                {
                    int tempCode = order.Items[i].Product.Code;

                    Product tempProduct = Products.Find(tempCode);

                    if (!Products.ValidateProduct(tempProduct))
                    {
                        Orders.RefundOrder(order.Number);
                        return;
                    }
                }

            }

            var ordersNotRefunded = paymentComplete.Where(o => o.PaymentRefunded == false);

            bool checkStock = true;
            bool checkAvailability = true;


            foreach (var order in ordersNotRefunded)
            {
                for (int i = 0; i < order.Items.Count; i++)
                {
                    

                    int tempCode = order.Items[i].Product.Code;

                    Product tempProduct = Products.Find(tempCode);

                    int stock = Products.GetStock(tempProduct.Code);

                    if (stock < order.Items[i].Count)
                    {
                        checkStock = false;
                    }
                    if (order.Items[i].Product.Firstavailable >= DateTime.Now)
                    {
                        checkAvailability = false;
                    }

                }

                if (checkStock && checkAvailability)
                {
                    for (int i = 0; i < order.Items.Count; i++)
                    {
                        Products.DispatchStock(order.Items[i].Product.Code, order.Items[i].Count);
                    }

                    Orders.DispatchOrder(order.Number);
                    listOfProcessed.Add(order.Number);
                }

                checkStock = true;
                checkAvailability = true;
            }
            
            string processedOrders = string.Join(",", listOfProcessed);
            MessageBox.Show("Orders: " + processedOrders + " has been processed");

        }
    }
}