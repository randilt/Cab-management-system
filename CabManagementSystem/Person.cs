using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabManagementSystem
{
    internal class Person
    {
        public string Name { get; private set; }
        public string ContactNumber { get; private set; }

        // Constructor
        public Person(string name, string contactNumber)
        {
            Name = name;
            ContactNumber = contactNumber;
        }
    }
}
