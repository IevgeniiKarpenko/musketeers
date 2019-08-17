using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        private string _city;
        private int _postalCode;
        public string _country;

        public User(string name, string email, string city, int postalCode, string country)
        {
            Name = name;
            Email = email;
            _city = city;
            _postalCode = postalCode;
            _country = country;
        }
    }
}
