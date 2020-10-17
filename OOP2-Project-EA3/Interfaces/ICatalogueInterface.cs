using System.Collections.Generic;

namespace OOP2_Project_EA3
{
    public interface ICatalogue<T>
    {
        /// <summary>
        /// Adds an object 'obj' to the catalogue.
        /// </summary>
        /// <param name="obj"> Object to be added to the catalogue.</param>
        void Add(T obj);

        /// <summary>
        /// Finds the object based on the specified identifier.
        /// </summary>
        /// <param name="identifier">The unique identifier for objects in catalogue eg. for customers: customerNumber</param>
        /// <returns>The object with the specified identifier.</returns>
        /// <exception cref="System.InvalidOperationException">If zero or more than one object are found an exception is thrown.</exception>
        Product Find(int identifier);

        /// <summary>
        /// Removes the object 'obj' from the catalogue.
        /// </summary>
        /// <param name="obj">The object to be removed</param>
        /// <returns>Returns true if object was successfully removed from catalogue.</returns>
        bool Remove(T obj);

        /// <summary>
        /// Updates an object in the collection by replacing it with a new object.
        /// </summary>
        /// <param name="oldObj">Current object in the collection</param>
        /// <param name="newObj">New object to replace the old object with</param>
        /// <returns>True if the object was found and successfully replaced with the new object. </returns>
        bool Replace(T oldObj, T newObj);

        /// <summary>
        /// Get all objects in the catalogue.
        /// </summary>
        /// <returns>An IEnumerable with all objects stored in the catalogue.</returns>
        IEnumerable<T> GetAll();
    }
}