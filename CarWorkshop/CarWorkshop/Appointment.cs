using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop
{
    public class Appointment
    {
        public Appointment(string userName, string carTrademark, string companyName, DateTime time)
        {
            UserName = userName;
            CarTrademark = carTrademark;
            CompanyName = companyName;
            Time = time;
        }

        public string UserName { get; set; }
        public string CarTrademark { get; set; }
        public string CompanyName { get; set; }
        public DateTime Time { get; set; }
    }
}
