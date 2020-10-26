using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace OOP2_Project_EA3
{
    public class ProductCatalogue : IProducts
    {
        private List<Product> _products;

        /// <summary>
        /// Path of folder to store json files
        /// </summary>
        private readonly string _folder;

        /// <summary>
        /// The constructor take the folder location of the file "products.json" and reads the contents of the file.
        /// </summary>
        /// <param name="folder">Location of folder to store the json file "products.json".</param>
        public ProductCatalogue(string folder)
        {
            this._folder = folder;
            InitiateCatalogue();
        }

        /// <summary>
        /// Invoked when there is any changes made to the catalogue.
        /// </summary>
        public event EventHandler CatalogueChanged;

        /// <summary>
        /// Invokes CatalogueChanged and writes updates to json file.
        /// </summary>
        private void OnCatalogueChanged()
        {
            CatalogueChanged?.Invoke(this, new EventArgs());
            WriteToFile();
        }

        /// <summary>
        /// Write contents of catalogue to json file.
        /// </summary>
        private void WriteToFile()
        {
            string contents = JsonSerializer.Serialize(_products);
            File.WriteAllText(_folder + "\\products.json", contents);
        }

        /// <summary>
        /// Reads contents from json file, if it exists, and stores in catalogue. Otherwise creates new internal list for catalogue.
        /// </summary>
        private void InitiateCatalogue()
        {
            if (File.Exists(_folder + "\\products.json"))
            {
                string fileContents = File.ReadAllText(_folder + "\\products.json");
                _products = JsonSerializer.Deserialize<List<Product>>(fileContents);
            }
            else _products = new List<Product>();
        }

        /// <summary>
        /// Adds an object 'obj' to the catalogue.
        /// </summary>
        /// <param name="obj"> Object to be added to the catalogue.</param>
        public void Add(Product obj)
        {
            if (_products.Exists(x => x.Code == obj.Code))
            {
                throw new Exception("A product with that number already exists in catalogue!");
            }
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj),"Object cannot be null!");
            }
            _products.Add(obj);
            OnCatalogueChanged();
        }

        /// <summary>
        /// Finds the object based on the specified identifier.
        /// </summary>
        /// <param name="identifier">The unique identifier for objects in catalogue eg. for customers: customerNumber</param>
        /// <returns>The object if found, otherwise returns null.</returns>
        /// <exception cref="System.InvalidOperationException">If zero or more than one object are found an exception is thrown.</exception>
        public Product Find(int identifier)
        {
            return _products.Single(obj =>obj.Code== identifier);
        }

        /// <summary>
        /// Removes the object 'obj' from the catalogue.
        /// </summary>
        /// <param name="obj">The object to be removed</param>
        /// <returns>Returns true if object was successfully removed from catalogue.</returns>
        public bool Remove(Product obj)
        {
            if (_products.Remove(obj))
            {
                OnCatalogueChanged();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Updates an object in the collection by replacing it with a new object.
        /// </summary>
        /// <param name="oldObj">Current object in the collection</param>
        /// <param name="newObj">New object to replace the old object with</param>
        /// <returns>True if the object was found and successfully replaced with the new object. </returns>
        public bool Update(Product oldObj, Product newObj)
        {
            if (oldObj.Code != newObj.Code)
            {
                throw new Exception("The new object needs to have the same identifier as the old one.");
            }
            if (oldObj == null || newObj == null)
            {
                throw new ArgumentNullException();
            }
            int index = _products.IndexOf(oldObj);
            if (index != -1)
            {
                _products[index] = newObj;
                OnCatalogueChanged();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get all objects in the catalogue.
        /// </summary>
        /// <returns>An IEnumerable with all objects stored in the catalogue.</returns>
        public IEnumerable<Product> GetAll()
        {
            return _products.ToList() ;
        }

        /// <summary>
        /// Retrieves number of items with given productCode available for dispatch.
        /// </summary>
        /// <param name="productCode">Code for the product of interest.</param>
        /// <returns>Number of available items.</returns>
        public int GetStock(int productCode)
        {
            return _products.Single(x => x.Code == productCode).Stock;
        }

        /// <summary>
        /// Updates stock in product catalogue for specific product.
        /// </summary>
        /// <param name="productCode">Code of the product of interest</param>
        /// <param name="items">Number of items to add to the stock, if add is negative the stock is decreased.</param>
        /// <returns>Returns true if operation was successful. False if e.g the resulting count would be less than zero.</returns>
        public void DispatchStock(int productCode, int items)
        {
            int index = _products.FindIndex(x => x.Code == productCode);
            if (_products[index].Stock - items < 0)
            {
                throw new InvalidOperationException("Cannot dispatch more items than there is stock!");
            }
            else
            {
                _products[index].Stock -= items;
            }
            
        }

        /// <summary>
        /// Checks that the product exists in the catalogue and that all information is correct. Returns true if product exists and it's information is correct.
        /// </summary>
        /// <param name="product">Product to be validated.</param>
        /// <returns>True if product exists and it's information is correct.</returns>
        public bool ValidateProduct(Product product)
        {
            return _products.Exists(x => 
                x.Code == product.Code && x.Name == product.Name && Math.Abs(x.Price - product.Price) < 0.01);
        }


    }
}