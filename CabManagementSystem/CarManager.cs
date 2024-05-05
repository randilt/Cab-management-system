using System;
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
        // Method to view all available cars
        public void ViewAvailableCars()
        {
            bool foundAvailableCar = false;
            Console.WriteLine("Available Cars:");
            foreach (Car car in cars)
            {
                if (car.Availability)
                {
                    foundAvailableCar = true;
                    Console.WriteLine(car.GetDetails());
                }
            }
            if (!foundAvailableCar)
            {
                Console.WriteLine("No available cars.");
            }
        }

        // Method to view all unavailable cars
        public void ViewUnavailableCars()
        {
            bool foundUnavailableCar = false;
            Console.WriteLine("Unavailable Cars:");
            foreach (Car car in cars)
            {
                if (!car.Availability)
                {
                    foundUnavailableCar = true;
                    Console.WriteLine(car.GetDetails());
                }
            }
            if (!foundUnavailableCar)
            {
                Console.WriteLine("No unavailable cars.");
            }
        }

        // Method to view all available drivers
        public void ViewAvailableDrivers()
        {
            bool foundAvailableDriver = false;
            Console.WriteLine("Available Drivers:");
            foreach (Driver driver in drivers)
            {
                if (driver.Availability)
                {
                    foundAvailableDriver = true;
                    Console.WriteLine(driver.GetDetails());
                }
            }
            if (!foundAvailableDriver)
            {
                Console.WriteLine("No available drivers.");
            }
        }

        // Method to view all unavailable drivers
        public void ViewUnavailableDrivers()
        {
            bool foundUnavailableDriver = false;
            Console.WriteLine("Unavailable Drivers:");
            foreach (Driver driver in drivers)
            {
                if (!driver.Availability)
                {
                    foundUnavailableDriver = true;
                    Console.WriteLine(driver.GetDetails());
                }
            }
            if (!foundUnavailableDriver)
            {
                Console.WriteLine("No unavailable drivers.");
            }
        }

        public void PlaceOrder(Order order)
        {
            if (order != null)
            {
                AddOrder(order); // Add the order to carManager
                Console.WriteLine("Order Placed:");
                Console.WriteLine(order.GetDetails());
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
        public void AssignDriverToCar(Driver driver, Car car)
        {
            car.SetAssignedDriver(driver);
        }

        public void UnassignDriverFromCar(Car car)
        {
            car.AssignedDriver = null;
        }
        private List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public List<Order> GetOrders()
        {
            return orders;
        }
        public void DisplayCurrentOrders()
        {
            if (orders.Count > 0)
            {
                foreach (var order in orders)
                {
                    Console.WriteLine(order.GetDetails());
                }
            }
            else
            {
                Console.WriteLine("No orders placed.");
            }
        }
    }
}
