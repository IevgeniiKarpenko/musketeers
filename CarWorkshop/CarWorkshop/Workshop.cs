using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop
{
    public class Workshop
    {
        public string Name { get; set; }
        public string CarTrademark { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        private int _postalCode;

        public Workshop(string name, string carTrademark, string city, int postalCode, string country)
        {
            Name = name;
            CarTrademark = carTrademark;
            City = city;
            Country = country;
            _postalCode = postalCode;
        }
    }
}
