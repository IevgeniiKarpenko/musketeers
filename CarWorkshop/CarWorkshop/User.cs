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
        public string Country { get; set; }
        public string City { get; set; }

        private int _postalCode;

        public User(string name, string email, string city, int postalCode, string country)
        {
            Name = name;
            Email = email;
            City = city;
            Country = country;
            _postalCode = postalCode;
        }
    }
}
