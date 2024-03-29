﻿using System;
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

        public CarWorkshop()
        {
            Users = new BindingList<User>();
            Workshops = new BindingList<Workshop>();
            Appointments = new BindingList<Appointment>();
            Cars = new BindingList<string>();
        }

        public bool AddUser(string name, string email, string city, string postalCode, string country)
        {
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(city) ||
                string.IsNullOrWhiteSpace(postalCode) ||
                string.IsNullOrWhiteSpace(country) ||
                !int.TryParse(postalCode, out var code))
            {
                return false;
            }

            if (Users.Any(u => u.Name == name || u.Email == email))
                return false;

            Users.Add(new User(name, email, city, code, country));

            return true;
        }

        public bool AddWorkshop(string name, string carTrademark, string city, string postalCode, string country)
        {
            if (Workshops.Any(w => w.Name == name))
                return false;

            if (string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(carTrademark) ||
            string.IsNullOrWhiteSpace(city) ||
            string.IsNullOrWhiteSpace(postalCode) ||
            string.IsNullOrWhiteSpace(country) ||
            !int.TryParse(postalCode, out var code))
            {
                return false;
            }


            Workshops.Add(new Workshop(name, carTrademark, city, code, country));
            Cars.Add(carTrademark);

            return true;
        }

        public bool CreateAppoitment(string userName, string carTrademark, string companyName, DateTime time)
        {
            if (string.IsNullOrWhiteSpace(userName) ||
                string.IsNullOrWhiteSpace(carTrademark) ||
                string.IsNullOrWhiteSpace(companyName) ||
                time < DateTime.Now)
            {
                return false;
            }

            Appointments.Add(new Appointment(userName, carTrademark, companyName, time));
            return true;
        }

        public IEnumerable<Workshop> FindWorkshops(string city)
        {
            return Workshops.Where(w => w.City == city);
        }

        public BindingList<Workshop> GetWorkshopsForCity(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
                return null;

            var res = Workshops.Where(w => w.City == city).ToList();

            return new BindingList<Workshop>(res);
        }
    }
}
