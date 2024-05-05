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

        // Method to place an order
        // Method to place an order and update availability of driver and car
        public Order PlaceOrder(Driver selectedDriver, Car selectedCar, DateTime date)
        {
            // Check if the selected driver and car are available
            if (selectedDriver.Availability && selectedCar.Availability)
            {
                // Create a new order
                Order order = new Order(OrderIdGenerator.GenerateOrderId(), this, selectedDriver, date);

                // Update the availability status of the car and driver
                selectedCar.UpdateAvailability(false);
                selectedDriver.UpdateAvailability(false);

                // Set the assigned driver for the car
                selectedCar.SetAssignedDriver(selectedDriver);

                return order;
            }
            else
            {
                Console.WriteLine("Selected driver or car is not available.");
                return null;
            }
        }
    }
}
