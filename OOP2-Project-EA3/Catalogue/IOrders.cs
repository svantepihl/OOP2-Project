using System.Collections;
using System.Configuration;
using System.Collections.Generic;

namespace OOP2_Project_EA3
{
    public interface IOrders : ICatalogue<Order>
    {
        /// <summary>
        /// Refunds the order with the order number passed as argument.
        /// </summary>
        /// <param name="orderNumber">Order number of order to be refunded.</param>
        /// <exception cref="System.InvalidOperationException">If the order does not exists in the catalogue.</exception>
        void RefundOrder(int orderNumber);

        /// <summary>
        /// Dispatches the order with the order number passed as argument.
        /// </summary>
        /// <param name="orderNumber">Order number of order to be dispatched.</param>
        /// <exception cref="System.InvalidOperationException">If the order does not exists in the catalogue.</exception>
        void DispatchOrder(int orderNumber);

        /// <summary>
        /// 
        /// 
        /// </summary>
        IEnumerable<Order> GetPendingOrders();

        IEnumerable<Order> GetDispatchedOrders();

        string EarliestDispatch(Order order);
    }
}