using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabManagementSystem
{
    internal class Car
    {

        private int carId;
        private string model;
        private string plateNumber;
        private bool availability;
        private Driver assignedDriver;


        public int CarId
        {
            get { return carId; }
            private set { carId = value; }
        }

        public string Model
        {
            get { return model; }
            private set { model = value; }
        }

        public string PlateNumber
        {
            get { return plateNumber; }
            private set { plateNumber = value; }
        }

        public bool Availability
        {
            get { return availability; }
            private set { availability = value; }
        }

        public Driver AssignedDriver
        {
            get { return assignedDriver; }
            set { assignedDriver = value; }
        }

        // Constructor
        public Car(int carId, string model, string plateNumber, bool availability)
        {
            CarId = carId;
            Model = model;
            PlateNumber = plateNumber;
            Availability = availability;
        }

        // Method to update availability status of the car
        public void UpdateAvailability(bool available)
        {
            Availability = available;
        }

        // Method to set the assigned driver for the car
        public void SetAssignedDriver(Driver driver)
        {
            AssignedDriver = driver;
            driver.AssignedCar = this; // Update the AssignedCar property of the driver
        }

        // Method to get details of the car
        public string GetDetails()
        {
            string details = $"Car ID: {CarId}\n";
            details += $"Model: {Model}\n";
            details += $"Plate Number: {PlateNumber}\n";
            details += $"Availability: {(Availability ? "Available" : "Not Available")}\n";
            if (AssignedDriver != null)
            {
                details += $"Assigned Driver: {AssignedDriver.Name}\n";
            }
            else
            {
                details += "Assigned Driver: None\n";
            }
            return details;
        }
    }
}
