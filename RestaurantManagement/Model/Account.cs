using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Model
{
    internal class Account
    {


        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Account()
        {
        }
        public Account(string displayName, string userName, string password, string role)
        {
            DisplayName = displayName;
            UserName = userName;
            Password = password;
            Role = role;
        }
    }
}
