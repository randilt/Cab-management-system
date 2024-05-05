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
            // Create car manager instance
            CarManager carManager = new CarManager();

            // Add some cars and drivers
            Car car1 = new Car(1, "Toyota Camry", "ABC123", true);
            Car car2 = new Car(2, "Honda Civic", "XYZ789", true);
            Driver driver1 = new Driver(101, "John Doe", "1234567890", true);
            Driver driver2 = new Driver(102, "Jane Doe", "0987654321", true);

            carManager.AddCar(car1);
            carManager.AddCar(car2);
            carManager.AddDriver(driver1);
            carManager.AddDriver(driver2);

            // Display available cars and drivers before placing order

            carManager.ViewAvailableCars();
            Console.WriteLine();

            carManager.ViewAvailableDrivers();
            Console.WriteLine();

            // Create a customer
            Customer customer = new Customer(201, "Alice", "9876543210", "A", "B");
            Customer customer1 = new Customer(202, "Bob", "9876543211", "B", "C");

            // Place an order
            Order order = customer.PlaceOrder(driver1, car1, DateTime.Now);
            Order order2 = customer1.PlaceOrder(driver2, car2, DateTime.Now);

            // Display details of the order placed
            carManager.PlaceOrder(order);
            carManager.PlaceOrder(order2);

            // Display updated availability of cars and drivers after placing order
            Console.WriteLine("Updated Availability:");
            carManager.ViewAvailableCars();
            carManager.ViewAvailableDrivers();
            Console.WriteLine();

            // Display current orders placed
            Console.WriteLine("Current Orders Placed:");
            carManager.DisplayCurrentOrders();
        }

  
    }
}
