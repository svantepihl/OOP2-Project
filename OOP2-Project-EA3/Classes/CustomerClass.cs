using System;

namespace OOP2_Project_EA3
{
    public class Customer
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
            get => _number;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Customer number cannot be less than zero!");
                }

                _number = value;
            }
        }

        /// <summary>
        /// A customer first- and lastname
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value),"Name cannot be empty or null!");
                }
                _name = value;
            }
        }

        /// <summary>
        /// A customers phone number including country code.
        /// </summary>
        public string Phone
        {
            get => _phone;
            set
            {
                // TODO: Kolla att det är ett riktigt telefonnummer
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value),"Phone number cannot be empty or null!");
                }
                _phone = value;
            }
        }

        /// <summary>
        /// A customers email address.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                // TODO: Kolla om det är en riktigt epostadress
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value),"Email cannot be empty or null!");
                }

                _email = value;
            }
        }


        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return  "#" + _number + " Name: " + _name;
        }
    }
}