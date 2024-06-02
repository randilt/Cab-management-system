using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabManagementGUI
{
    public abstract class Person
    {
        private string _name;
        private string _contactNumber;
        private string _email;
        private string _nic;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string ContactNumber
        {
            get { return _contactNumber; }
            set { _contactNumber = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string NIC
        {
            get { return _nic; }
            set { _nic = value; }
        }

        public Person(string name, string contactNumber, string email, string nic)
        {
            _name = name;
            _contactNumber = contactNumber;
            _email = email;
            _nic = nic;
        }
    }
}
