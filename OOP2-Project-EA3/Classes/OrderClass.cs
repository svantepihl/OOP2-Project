using System;
using System.Collections.Generic;


namespace OOP2_Project_EA3
{
    public class Order
    {
        private int _number;
        private Customer _customer;
        private DateTime _orderDate;
        private string _deliveryAddress;
        private bool _paymentCompleted;
        private bool _paymentRefunded;
        private bool _dispatched;
        private List<OrderLine> _items;
        private DateTime _dispatchDate; //får man lägga till egna variabler?

        /// <summary>
        /// A orders unique 'order number'.
        /// </summary>
        public int Number
        {
            get => _number;
            set => _number = value;
        }

        /// <summary>
        /// The customer who placed the order.
        /// </summary>
        public Customer Customer
        {
            get => _customer;
            set => _customer = value;
        }

        /// <summary>
        /// Date and time when the order was placed. 
        /// </summary>
        public DateTime OrderDate
        {
            get => _orderDate;
            set => _orderDate = value;
        }
        
        /// <summary>
        ///  Delivery address associated with the order.
        /// </summary>
        public string DeliveryAddress
        {
            get => _deliveryAddress;
            set => _deliveryAddress = value;
        }

        /// <summary>
        /// All products their quantities in the order.
        /// </summary>
        public List<OrderLine> Items
        {
            get => _items;
            set => _items = value;
        }

        /// <summary>
        /// True if the payment for the order has been collected and false otherwise.
        /// </summary>
        public bool PaymentCompleted
        {
            get => _paymentCompleted;
            set => _paymentCompleted = value;
        }
        
        /// <summary>
        /// True if the order has been refunded and false otherwise.
        /// </summary>
        public bool PaymentRefunded
        {
            get => _paymentRefunded;
            set => _paymentRefunded = value;
        }

        /// <summary>
        /// True if the order has been dispatched, false otherwise.
        /// </summary>
        public bool Dispatched
        {
            get => _dispatched;
            set => _dispatched = value;
        }

        ///<summary>
        ///Date and Time when order was dispatched or estimated dispatch date
        /// </summary>
        public DateTime DispatchDate
        {
            get => _dispatchDate;
            set => _dispatchDate = value;
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return "#" + _number + "  " + _orderDate.ToShortDateString() + "  Dispatched: " + _dispatched;
        }
    }
}