// TODO: {Här skriver vi saker som behöver göras i denna class}

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


        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return  "#" + _number + " Name: " + _name;
        }
    }
}