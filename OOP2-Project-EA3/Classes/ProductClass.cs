using System;
using System.Diagnostics;

// TODO: {Här skriver vi saker som behöver göras i denna class}

namespace OOP2_Project_EA3
{
    public class Product
    {
        private int _code;
        private string _name;
        private double _price;
        private int _stock;

        /// <summary>
        /// A products unique product code.
        /// </summary>
        public int Code
        {
            // TODO: Code får inte vara negativt, kasstar exception om felaktigt
            get => _code;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Product code must be positive.");
                }
                else
                {
                    _code = value;
                }
            }
        }

        /// <summary>
        /// A products offical name.
        /// </summary>
        public string Name
        {
            // TODO: Namn får inte vara tomt eller null, kastar exception om felaktigt.
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "Name cannot be null or empty.");
                }
                _name = value;
            }
        }

        /// <summary>
        /// The price of the product with two decimalsplaces precision.
        /// </summary>
        public double Price
        {
            get => _price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Price cannot be negative.");
                }
                else
                {
                    _price = Math.Round(value, 2);
                }
            }
        }

        /// <summary>
        /// Number items of this product that are ready to be dispatched from warehouse.
        /// </summary>
        public int Stock
        {
            get => _stock;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Stock cannot be negative!");
                }
                else
                {
                    _stock = value;
                }
            }
        }

        /// <summary>
        /// Returns first possible DateTime when the product is available.
        /// </summary>
        public DateTime FirstAvailable()
        {
            // TODO: Vart ska informationen komma ifrån?
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the next DataTime when item will be in stock.
        /// </summary>
        public DateTime NextStocking()
        {   // TODO: Vart ska informationen komma ifrån?
            throw new NotImplementedException();
        }
    }
}