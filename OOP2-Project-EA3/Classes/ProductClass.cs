using System;


namespace OOP2_Project_EA3
{
    public class Product
    {
        private int _code;
        private string _name;
        private double _price;
        private int _stock;
        private DateTime _firstavailable;
        private DateTime _nextStocking;

        /// <summary>
        /// A products unique product code.
        /// </summary>
        public int Code
        {
            get => _code;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Product code must be positive.");
                }

                _code = value;
            }
        }

        /// <summary>
        /// A products official name.
        /// </summary>
        public string Name
        {
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

                _price = Math.Round(value, 2);
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

                _stock = value;
            }
        }


        /// <summary>
        /// Date the product will be released.
        /// </summary>
        public DateTime Firstavailable
        {
            get => _firstavailable;
            set => _firstavailable = value;
        }

        /// <summary>
        /// Stores the next date that the product will be restocked.
        /// </summary>
        public DateTime NextStocking
        {
            get => _nextStocking;
            set => _nextStocking = value;
        }


        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return "#" + _code + " Name: " + _name;
        }
    }
}