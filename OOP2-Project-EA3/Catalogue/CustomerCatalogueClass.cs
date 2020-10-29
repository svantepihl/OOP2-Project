using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace OOP2_Project_EA3
{
    public class CustomerCatalogue : ICustomers
    {
        private List<Customer> _customers;

        /// <summary>
        /// Path of folder to store json files
        /// </summary>
        private readonly string _folder;

        /// <summary>
        /// The constructor take the folder location of the file "customers.json" and reads the contents of the file.
        /// </summary>
        /// <param name="folder">Location of folder to store the json file "customers.json".</param>
        public CustomerCatalogue(string folder)
        {
            _folder = folder;
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
            string contents = JsonSerializer.Serialize(_customers);
            File.WriteAllText(_folder + "\\customers.json", contents);
        }

        /// <summary>
        /// Reads contents from json file, if it exists, and stores in catalogue. Otherwise creates new internal list for catalogue.
        /// </summary>
        private void InitiateCatalogue()
        {
            if (File.Exists(_folder + "\\customers.json"))
            {
                string fileContents = File.ReadAllText(_folder +"\\customers.json");
                _customers = JsonSerializer.Deserialize<List<Customer>>(fileContents);
            }
            else _customers = new List<Customer>();
        }

        /// <summary>
        /// Adds an object 'obj' to the catalogue.
        /// </summary>
        /// <param name="obj"> Object to be added to the catalogue.</param>
        public void Add(Customer obj)
        {
            if (_customers.Exists(x => x.Number == obj.Number))
            {
                throw new Exception("Customer with that number already exists in catalogue!");
            }
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "Object cannot be null!");
            }
            _customers.Add(obj);
            OnCatalogueChanged();
        }

        /// <summary>
        /// Finds the object based on the specified identifier.
        /// </summary>
        /// <param name="identifier">The unique identifier for objects in catalogue eg. for customers: customerNumber</param>
        /// <returns>The object with the specified identifier.</returns>
        /// <exception cref="System.InvalidOperationException">If zero or more than one object are found an exception is thrown.</exception>
        public Customer Find(int identifier)
        {
            return _customers.Single(obj => obj.Number == identifier);
        }

        /// <summary>
        /// Removes the object 'obj' from the catalogue.
        /// </summary>
        /// <param name="obj">The object to be removed</param>
        /// <returns>Returns true if object was successfully removed from catalogue.</returns>
        public bool Remove(Customer obj)
        {
            if (_customers.Remove(obj))
            {
                OnCatalogueChanged();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Updates an object in the collection by replacing it with a new object with the same identifier.
        /// </summary>
        /// <param name="oldObj">Current object in the collection.</param>
        /// <param name="newObj">New object to replace the old object with the same identifier</param>
        /// <returns>True if the object was found and successfully replaced with the new object. </returns>
        public bool Update(Customer oldObj, Customer newObj)
        {
            if (oldObj.Number != newObj.Number)
            {
                throw new Exception("The new object needs to have the same identifier as the old one.");
            }

            if (oldObj == null || newObj == null)
            {
                throw new ArgumentNullException();
            }
            int index = _customers.IndexOf(oldObj);
            if (index != -1)
            {
                _customers[index] = newObj;
                OnCatalogueChanged();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get all objects in the catalogue.
        /// </summary>
        /// <returns>An IEnumerable with all objects stored in the catalogue.</returns>
        public IEnumerable<Customer> GetAll()
        {
            return _customers.ToList();
        }
    }
}