using System;

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
            get => _code;
            set => _code = value;
        }

        /// <summary>
        /// A products offical name.
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        /// <summary>
        /// The price of the product with two decimalsplaces precision.
        /// </summary>
        public double Price
        {
            get => _price;
            set => _price = Math.Round(value,2);
        }

        /// <summary>
        /// Number items of this product that are ready to be dispatched from warehouse.
        /// </summary>
        public int Stock
        {
            get => _stock;
            set => _stock = value;
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