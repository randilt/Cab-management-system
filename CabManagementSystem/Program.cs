using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a CarManager instance
            CarManager carManager = new CarManager();

            // Create cars and add them to the CarManager
            Car car1 = new Car(1, "Toyota Camry", "ABC123", true);
            carManager.AddCar(car1);

            Car car2 = new Car(2, "Honda Civic", "XYZ789", true);
            carManager.AddCar(car2);

            Car car3 = new Car(3, "Ford Mustang", "DEF456", false);
            carManager.AddCar(car3);

            // Display available cars
            carManager.ViewAvailableCars();

            // Create a Customer instance
            Customer customer1 = new Customer(1, "John Doe", "1234567890", "CurrentLocation", "Destination");

            // Display customer details
            Console.WriteLine("\nCustomer Details:");
            Console.WriteLine(customer1.GetDetails());

            // View available cars
            customer1.ViewAvailableCars();

            // View available drivers
            customer1.ViewAvailableDrivers();

            // Place an order
            customer1.PlaceOrder();
        }
    }
}
