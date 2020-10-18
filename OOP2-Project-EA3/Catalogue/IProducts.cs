namespace OOP2_Project_EA3
{
    public interface IProducts : ICatalogue<Product>
    {
        /// <summary>
        /// Retrieves number of items with given productCode available for dispatch.
        /// </summary>
        /// <param name="productCode">Code for the product of interest.</param>
        /// <returns>Number of available items.</returns>
        int GetStock(int productCode);

        /// <summary>
        /// Dispatches selected number of items of selected product from stock.
        /// </summary>
        /// <param name="productCode">Code of the product to be dispatched.</param>
        /// <param name="items">Number of items to remove from stock.</param>
        /// <returns>Returns true if operation was successful. False if e.g the resulting count would be less than zero.</returns>
        /// <exception cref="System.InvalidOperationException">If product does not exists in product catalogue.</exception>
        void DispatchStock(int productCode, int items);

        /// <summary>
        /// Checks that the product exists in the catalogue and that all information is correct. Returns true if product exists and it's information is correct.
        /// </summary>
        /// <param name="product">Product to be validated.</param>
        /// <returns>True if product exists and it's information is correct.</returns>
        bool ValidateProduct(Product product);
    }
}