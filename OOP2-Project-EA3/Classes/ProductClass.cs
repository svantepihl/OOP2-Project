using System;
using System.Diagnostics;

// TODO: {Här skriver vi saker som behöver göras i denna class}

namespace OOP2_Project_EA3
{
    public class Product : IEquatable<Product>
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

        // Följande metoder finns för att kunna säkerställa att en produkt endast finns med en gång vår produktkatalog. Kommer kanske inte behövas...

        /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
        public bool Equals(Product other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _code == other._code && _name == other._name && _price.Equals(other._price) && _stock == other._stock;
        }

        /// <summary>Determines whether the specified object is equal to the current object.</summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>
        /// <see langword="true" /> if the specified object  is equal to the current object; otherwise, <see langword="false" />.</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Product) obj);
        }

        /// <summary>Serves as the default hash function.</summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(_code, _name, _price, _stock);
        }
    }
}