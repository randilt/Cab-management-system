using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabManagementSystem
{
    internal static class OrderIdGenerator
    {
        private static int orderIdCounter = 1;

        public static int GenerateOrderId()
        {
            return orderIdCounter++;
        }
    }
}
