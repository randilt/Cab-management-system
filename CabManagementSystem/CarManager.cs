﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabManagementSystem
{
    internal class CarManager
    {
        private List<Car> cars;
        private List<Driver> drivers;

        // Constructor
        public CarManager()
        {
            cars = new List<Car>();
            drivers = new List<Driver>();
        }

        // Method to add a new car
        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        // Method to remove a car
        public void RemoveCar(Car car)
        {
            cars.Remove(car);
        }

        // Method to view all available cars
        public void ViewAvailableCars()
        {
            Console.WriteLine("Available Cars:");
            foreach (Car car in cars)
            {
                if (car.Availability)
                {
                    Console.WriteLine(car.GetDetails());
                }
            }
        }
        // Method to view all unavailable cars
        public void ViewUnavailableCars()
        {
            Console.WriteLine("Unavailable Cars:");
            foreach (Car car in cars)
            {
                if (!car.Availability)
                {
                    Console.WriteLine(car.GetDetails());
                }
            }
        }
        public void ViewAvailableDrivers()
        {
               Console.WriteLine("Available Drivers:");
            foreach (Driver driver in drivers)
            {
                if (driver.Availability)
                {
                    Console.WriteLine(driver.GetDetails());
                }
            }
        }
        public void ViewUnavailableDrivers()
        {
            Console.WriteLine("Unavailable Drivers:");
            foreach (Driver driver in drivers)
            {
                if (!driver.Availability)
                {
                    Console.WriteLine(driver.GetDetails());
                }
            }
        }
        public void AddDriver(Driver driver)
        {
            drivers.Add(driver);
        }
        public void RemoveDriver(Driver driver)
        {
            drivers.Remove(driver);
        }

    }
}
