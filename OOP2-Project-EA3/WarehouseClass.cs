namespace OOP2_Project_EA3
{
    public class Warehouse
    {
        public CustomerCatalogue Customers;

        public ProductCatalogue Products;

        public OrderCatalogue Orders;

        public Warehouse(string folder)
        {
            Customers = new CustomerCatalogue(folder);
            Products = new ProductCatalogue(folder);
            Orders = new OrderCatalogue(folder);
        }
    }
}