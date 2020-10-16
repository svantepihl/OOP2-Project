
// TODO: {Här skriver vi saker som behöver göras i denna class}

namespace OOP2_Project_EA3
{
    public class OrderLine
    {
        private Product _product;
        private int _count;
        
        /// <summary>
        /// Type of product on the order line.
        /// </summary>
        public Product Product
        {
            get => _product;
            set => _product = value;
        }

        /// <summary>
        /// Number of this product on the order line.
        /// </summary>
        public int Count
        {
            get => _count;
            set => _count = value;
        }
    }
}