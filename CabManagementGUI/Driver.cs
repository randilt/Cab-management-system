    using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabManagementGUI
{
    internal class Driver : Person
    {
        // Private fields
        private bool _availability;
        private int _driverId;

        // Public properties with encapsulation

        public int DriverId
        {
            get { return _driverId; }
            private set { _driverId = value; }
        }
        public bool Availability
        {
            get { return _availability; }
            set { _availability = value; }
        }

        public string DriverName
        {
            get { return Name; }
            set { Name = value; }
        }

        public string DriverContactNumber
        {
            get { return ContactNumber; }
            set { ContactNumber = value; }
        }

        public string DriverEmail
        {
            get { return Email; }
            set { Email = value; }
        }

        public string DriverNIC
        {
            get { return NIC; }
            set { NIC = value; }
        }



        // Constructor
        public Driver( string name, string contactNumber, string email, string nic, bool availability)
            : base(name, contactNumber, email, nic)
        {
            _availability = availability;
            DriverName = name;
            DriverContactNumber = contactNumber;
            DriverEmail = email;
            DriverNIC = nic;

        }

        // overloaded constructor with driverId
        public Driver(int driverId, string name, string contactNumber, string email, string nic, bool availability)
            : base(name, contactNumber, email, nic)
        {
            _driverId = driverId;
            _availability = availability;
            DriverName = name;
            DriverContactNumber = contactNumber;
            DriverEmail = email;
            DriverNIC = nic;

        }

        // Method to get driver details
        public string GetDetails()
        {
            return $"Name: {Name}\nContact Number: {ContactNumber}\nEmail: {Email}\nNIC: {NIC}\nAvailability: {Availability}";
        }

        

       
    }
}
