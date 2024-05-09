using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabManagementGUI
{
    internal class UserModel
    {
        public bool Login(string username, string password)
        {
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
