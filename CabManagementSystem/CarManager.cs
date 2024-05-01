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

        // Constructor
        public CarManager()
        {
            cars = new List<Car>();
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

    }
}
