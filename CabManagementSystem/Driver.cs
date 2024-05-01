using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CabManagementSystem
{
    internal class Driver : Person
    {
        public int DriverId { get; }
        public bool Availability { get; private set; }
        public Car AssignedCar { get;  set; }

        // Constructor
        public Driver(int driverId, string name, string contactNumber, bool availability)
            : base(name, contactNumber)
        {
            DriverId = driverId;
            Availability = availability;
        }

        // Method to update availability status of the driver
        public void UpdateAvailability(bool available)
        {
            Availability = available;
        }

        // Method to set the assigned car for the driver
        public void SetAssignedCar(Car car)
        {
            AssignedCar = car;
            car.AssignedDriver = this; // Update the AssignedDriver property of the car
        }

        // Method to get details of the driver
        public string GetDetails()
        {
            string details = $"Driver ID: {DriverId}\n";
            details += $"Name: {Name}\n";
            details += $"Contact Number: {ContactNumber}\n";
            details += $"Availability: {(Availability ? "Available" : "Not Available")}\n";
            if (AssignedCar != null)
            {
                details += $"Assigned Car: {AssignedCar.Model} ({AssignedCar.PlateNumber})\n";
            }
            else
            {
                details += "Assigned Car: None\n";
            }
            return details;
        }
    }
}
