// TODO: {Här skriver vi saker som behöver göras i denna class}

using System;

namespace OOP2_Project_EA3
{
    public class Customer : IEquatable<Customer>
    {
        private int _number;
        private string _name;
        private string _phone;
        private string _email;

        /// <summary>
        /// A customer unique 'customer number'
        /// </summary>
        public int Number
        {
            // TODO: Number får inte vara negativt, kassta exception om felaktigt
            get => _number;
            set => _number = value;
        }

        /// <summary>
        /// A customer first- and lastname
        /// </summary>
        public string Name
        {
            // TODO: Namn får inte vara tomt eller null, kasta exception om felaktigt.
            get => _name;
            set => _name = value;
        }

        /// <summary>
        /// A customers phone number including country code.
        /// </summary>
        public string Phone
        {
            // TODO: Phone får inte vara tomt eller null, kasta exception om felaktigt.
            get => _phone;
            set => _phone = value;
        }

        /// <summary>
        /// A customers email address.
        /// </summary>
        public string Email
        {
            // TODO: Email får inte vara tomt eller null, kasta exception om felaktigt.
            get => _email;
            set => _email = value;
        }

        // Följande metoder finns för att kunna säkerställa att en kund endast finns med en gång i vår kundkatalog. Kommer kanske inte behövas dock....

        /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
        public bool Equals(Customer other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _number == other._number && _name == other._name && _phone == other._phone && _email == other._email;
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
            return Equals((Customer) obj);
        }

        /// <summary>Serves as the default hash function.</summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(_number, _name, _phone, _email);
        }
    }
}