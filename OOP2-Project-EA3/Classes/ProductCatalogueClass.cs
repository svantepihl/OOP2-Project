using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace OOP2_Project_EA3
{
    public class ProductCatalogueClass : ICatalogue<Product>
    {
        private readonly ObservableCollection<Product> _products = new ObservableCollection<Product>();

        /// <summary>
        /// Adds an object 'obj' to the catalogue.
        /// </summary>
        /// <param name="obj"> Object to be added to the catalogue.</param>
        public void Add(Product obj)
        {
            if (obj != null)
            {
                _products.Add(obj);
            }
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
        public bool Replace(Product oldObj, Product newObj)
        {
            int index = _products.IndexOf(oldObj);
            if (index != -1)
            {
                _products[index] = newObj;
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
    }
}