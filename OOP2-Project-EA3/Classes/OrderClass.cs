using System;
using System.Collections.Generic;

// TODO: {Här skriver vi saker som behöver göras i denna class}

namespace OOP2_Project_EA3
{
    public class Order
    {
        private int _number;
        private Customer _customer;
        private DateTime _orderDate;
        private string _deliveryAddress;
        private List<OrderLine> _items;

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
        /// Returns true if the payment for the order has been collected and false otherwise.
        /// </summary>
        public bool PaymentCompleted()
        {
            throw new NotImplementedException(); // Hur ska denna funktion fungera?
        }

        /// <summary>
        /// Returns true if the order has been refunded and false otherwise.
        /// </summary>
        public bool PaymentRefunded()
        {
            throw new NotImplementedException(); // Hur ska denna funktion fungera?
        }
        
    }
}