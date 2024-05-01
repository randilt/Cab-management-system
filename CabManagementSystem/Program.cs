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
            CarManager carManager = new CarManager(); // Create a CarManager instance

            // Create cars and add them to the CarManager
            Car car1 = new Car(1, "Toyota Camry", "ABC123", true);
            carManager.AddCar(car1);

            Car car2 = new Car(2, "Honda Civic", "XYZ789", true);
            carManager.AddCar(car2);

            Car car3 = new Car(3, "Ford Mustang", "DEF456", false);
            carManager.AddCar(car3);

            // Display available cars
            carManager.ViewAvailableCars();
            carManager.ViewUnavailableCars();
        }
    }
}
