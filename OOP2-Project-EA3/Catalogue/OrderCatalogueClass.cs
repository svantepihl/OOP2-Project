using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace OOP2_Project_EA3
{
    public class OrderCatalogue: ICatalogue<Order>
    {
        private List<Order> _orders;

        /// <summary>
        /// Path of folder to store json files
        /// </summary>
        private readonly string _folder;

        /// <summary>
        /// The constructor take the folder location of the file "products.json" and reads the contents of the file.
        /// </summary>
        /// <param name="folder">Location of folder to store the json file "products.json".</param>
        public OrderCatalogue(string folder)
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
            string contents = JsonSerializer.Serialize(_orders);
            File.WriteAllText(_folder + "/products.json", contents);
        }

        /// <summary>
        /// Reads contents from json file, if it exists, and stores in catalogue. Otherwise creates new internal list for catalogue.
        /// </summary>
        private void InitiateCatalogue()
        {
            if (File.Exists(_folder))
            {
                string fileContents = File.ReadAllText(_folder + "/products.json");
                _orders = JsonSerializer.Deserialize<List<Order>>(fileContents);
            }
            else _orders = new List<Order>();
        }
        /// <summary>
        /// Adds an object 'obj' to the catalogue.
        /// </summary>
        /// <param name="obj"> Object to be added to the catalogue.</param>
        public void Add(Order obj)
        {
            if (_orders.Exists(x => x.Number == obj.Number))
            {
                throw new Exception("An order with that number already exists in the catalogue.");
            }
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "Object cannot be null!");
            }
            _orders.Add(obj);
        }

        /// <summary>
        /// Finds the object based on the specified identifier.
        /// </summary>
        /// <param name="identifier">The unique identifier for objects in catalogue eg. for customers: customerNumber</param>
        /// <returns>The object with the specified identifier.</returns>
        /// <exception cref="System.InvalidOperationException">If zero or more than one object are found an exception is thrown.</exception>
        public Order Find(int identifier)
        {
            return _orders.Single(obj => obj.Number == identifier);
        }

        /// <summary>
        /// Removes the object 'obj' from the catalogue.
        /// </summary>
        /// <param name="obj">The object to be removed</param>
        /// <returns>Returns true if object was successfully removed from catalogue.</returns>
        public bool Remove(Order obj)
        {
            if (_orders.Remove(obj))
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
        public bool Update(Order oldObj, Order newObj)
        {
            if (oldObj.Number != newObj.Number)
            {
                throw new Exception("The new object needs to have the same identifier as the old one.");
            }
            if (oldObj == null || newObj == null)
            {
                throw new ArgumentNullException();
            }
            int index = _orders.IndexOf(oldObj);
            if (index != -1)
            {
                _orders[index] = newObj;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get all objects in the catalogue.
        /// </summary>
        /// <returns>An IEnumerable with all objects stored in the catalogue.</returns>
        public IEnumerable<Order> GetAll()
        {
            return _orders.ToList();
        }
    }
}