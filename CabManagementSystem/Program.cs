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
            Car car1 = new Car(1, "Toyota Camry", "ABC123", true);

            // Display car details
            Console.WriteLine("Car Details:");
            Console.WriteLine(car1.GetDetails());

            // Create a driver
            Driver driver1 = new Driver(1, "John Doe", "1234567890", true);

            // Display driver details
            Console.WriteLine("\nDriver Details:");
            Console.WriteLine(driver1.GetDetails());

            // Assign the driver to the car
            car1.SetAssignedDriver(driver1);

            // Display updated car details
            Console.WriteLine("\nCar Details after assigning driver:");
            Console.WriteLine(car1.GetDetails());

            // Update availability of the driver
            driver1.UpdateAvailability(false);

            // Display updated driver details
            Console.WriteLine("\nDriver Details after updating availability:");
            Console.WriteLine(driver1.GetDetails());
        }
    }
}
