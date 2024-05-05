using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabManagementSystem
{
    internal class Order
    {
        public int OrderId { get; }
        public Customer Customer { get; }
        public Driver Driver { get; }
        public DateTime Date { get; }

        // Constructor
        public Order(int orderId, Customer customer, Driver driver, DateTime date)
        {
            OrderId = orderId;
            Customer = customer;
            Driver = driver;
            Date = date;
        }

        // Method to get details of the order
        public string GetDetails()
        {
            string details = $"Order ID: {OrderId}\n";
            details += $"Customer: {Customer.Name}\n";
            details += $"Driver: {Driver.Name}\n";
            details += $"Date: {Date}\n";
            return details;
        }
    }
}
