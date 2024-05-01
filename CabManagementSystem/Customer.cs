using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabManagementSystem
{
    internal class Customer : Person
    {
        public int CustomerId { get; private set; }
        public string CurrentLocation { get; set; }
        public string Destination { get; set; }

        // Constructor
        public Customer(int customerId, string name, string contactNumber, string currentLocation, string destination)
            : base(name, contactNumber)
        {
            CustomerId = customerId;
            CurrentLocation = currentLocation;
            Destination = destination;
        }

        // Method to get details of the customer
        public string GetDetails()
        {
            string details = $"Customer ID: {CustomerId}\n";
            details += $"Name: {Name}\n";
            details += $"Contact Number: {ContactNumber}\n";
            details += $"Current Location: {CurrentLocation}\n";
            details += $"Destination: {Destination}\n";
            return details;
        }

        // Method to view available cars
        public void ViewAvailableCars()
        {
            // Implementation to view available cars
        }

        // Method to view available drivers
        public void ViewAvailableDrivers()
        {
            // Implementation to view available drivers
        }

        // Method to place an order
        public void PlaceOrder()
        {
            // Implementation to place an order
        }
    }
}
