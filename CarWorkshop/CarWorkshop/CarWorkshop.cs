using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop
{
    public class CarWorkshop
    {
        public BindingList<User> Users;
        public BindingList<Workshop> Workshops;
        public BindingList<Appointment> Appointments;
        public BindingList<string> Cars;

        private Dictionary<string, string> uniqueUsers;

        public CarWorkshop()
        {
            Users = new BindingList<User>();
            Workshops = new BindingList<Workshop>();
            Appointments = new BindingList<Appointment>();
            uniqueUsers = new Dictionary<string, string>();
            Cars = new BindingList<string>();
        }

        public bool AddUser(string name, string email, string city, int postalCode, string country)
        {
            foreach (var user in uniqueUsers)
            {
                if (name == user.Key || email == user.Value)
                    return false;
            }

            uniqueUsers.Add(name, email);
            Users.Add(new User(name, email, city, postalCode, country));

            return true;
        }

        public bool AddWorkshop(string name, string carTrademark, string city, int postalCode, string country)
        {
            //if (Workshops.ContainsKey(name))
            //    return false;

            Workshops.Add(new Workshop(name, carTrademark, city, postalCode, country));
            Cars.Add(carTrademark);

            return true;
        }

        public void CreateAppoitment(string userName, string carTrademark, string companyName, DateTime time)
        {
            Appointments.Add(new Appointment(userName, carTrademark, companyName, time));
        }

        public void DeleteAppoitment(Appointment appoitment)
        {
            Appointments.Remove(appoitment);
        }

        public void DeleteAppoitment(string userName, string carTrademark, string companyName, DateTime time)
        {
            var appoitment = Appointments.FirstOrDefault(a => 
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
            return Workshops.Where(w => w.City == city);
        }
    }
}
