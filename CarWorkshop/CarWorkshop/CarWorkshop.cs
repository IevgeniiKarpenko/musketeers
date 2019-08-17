using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop
{
    public class CarWorkshop
    {
        public Dictionary<string, User> Users;
        public Dictionary<string, Workshop> Workshops;
        public List<Appointment> Appointments;

        private Dictionary<string, string> uniqueUsers;

        public CarWorkshop()
        {
            Users = new Dictionary<string, User>();
            Workshops = new Dictionary<string, Workshop>();
            Appointments = new List<Appointment>();
            uniqueUsers = new Dictionary<string, string>();
        }

        public bool AddUser(string name, string email, string city, int postalCode, string country)
        {
            foreach (var user in uniqueUsers)
            {
                if (name == user.Key || email == user.Value)
                    return false;
            }

            uniqueUsers.Add(name, email);
            Users.Add(name, new User(name, email, city, postalCode, country));

            return true;
        }

        public void AddWorkshop(string name, string carTrademark, string city, int postalCode, string country)
        {
            Workshops.Add(name, new Workshop(name, carTrademark, city, postalCode, country));
        }

        public void CreateAppoitment(string userName, string carTrademark, string companyName, DateTime time)
        {
            Appointments.Add(new Appointment(userName, carTrademark, companyName, time));
        }

        public void DeleteUser(string name)
        {
            Users.Remove(name);
        }

        public void DeleteWorkshop(string name)
        {
            Workshops.Remove(name);
        }

        public void DeleteAppoitment(Appointment appoitment)
        {
            Appointments.Remove(appoitment);
        }

        public void DeleteAppoitment(string userName, string carTrademark, string companyName, DateTime time)
        {
            var appoitment = Appointments.Find(a => 
                    a.UserName == userName &&  a.CarTrademark == carTrademark &&
                    a.CompanyName == companyName && a.Time == time);

            if (appoitment != null)
                Appointments.Remove(appoitment);
        }

        public void ChangeAppoitmentTime(Appointment appointment, DateTime time)
        {
            appointment.Time = time;
        }

        public IEnumerable<Workshop> FindWorkshops(string city)
        {
            return Workshops.Values.Where(w => w.City == city);
        }
    }
}
