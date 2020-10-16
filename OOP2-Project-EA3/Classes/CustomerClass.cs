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
            // Todo: Får inte vara negativt
            get => _number;
            set => _number = value;
        }

        /// <summary>
        /// A customer first- and lastname
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        /// <summary>
        /// A customers phone number including country code.
        /// </summary>
        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }

        /// <summary>
        /// A customers email address.
        /// </summary>
        public string Email
        {
            get => _email;
            set => _email = value;
        }
    }
}