using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWorkshop
{
    public partial class CarWorkshopApp : Form
    {
        public CarWorkshop carWorkshop;
        

        public CarWorkshopApp()
        {
            InitializeComponent();

            carWorkshop = new CarWorkshop();

            //Dummy data
            carWorkshop.Users.Add(new User("sad", "asda", "NYcity", 123, "aasd"));
            carWorkshop.Workshops.Add(new Workshop("STO", "BMW", "kiev", 000111, "UK"));

            AddBindings();
        }

        private void AddBindings()
        {
            users_dataGridView.DataSource = carWorkshop.Users;
            workshops_dataGridView.DataSource = carWorkshop.Workshops;
            app_dataGridView.DataSource = carWorkshop.Appointments;

            appUsr_comboBox.DataSource = carWorkshop.Users;
            appUsr_comboBox.DisplayMember = "Name";

            appCompany_comboBox.DataSource = carWorkshop.Workshops;
            appCompany_comboBox.DisplayMember = "Name";

            appCar_comboBox.DataSource = carWorkshop.Cars;
        }

        private void createUsr_button_Click(object sender, EventArgs e)
        {
            string name = usrName_textBox.Text;
            string email = usrEmail_textBox.Text;
            string city = usrCity_textBox.Text;
            string postalCode = usrPostal_textBox.Text;
            string country = usrCountry_textBox.Text;

            if(string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(city) ||
                string.IsNullOrWhiteSpace(postalCode) ||
                string.IsNullOrWhiteSpace(country) ||
                !int.TryParse(postalCode, out var code))
            {
                MessageBox.Show("Please input correct data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if(carWorkshop.AddUser(name, email, city, code, country))
            {
                ClearUserInputData();
            }
            else
            {
                MessageBox.Show("User with same Name or Email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearUserInputData()
        {
            usrName_textBox.Clear();
            usrEmail_textBox.Clear();
            usrCity_textBox.Clear();
            usrPostal_textBox.Clear();
            usrCountry_textBox.Clear();
        }

        private void createWorksop_button_Click(object sender, EventArgs e)
        {
            string name = wshopName_textBox.Text;
            string mark = wshopTrademark_textBox.Text;
            string city = wshopCity_textBox.Text;
            string postalCode = wshopPostal_textBox.Text;
            string country = wshopCountry_textBox.Text;

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(mark) ||
                string.IsNullOrWhiteSpace(city) ||
                string.IsNullOrWhiteSpace(postalCode) ||
                string.IsNullOrWhiteSpace(country) ||
                !int.TryParse(postalCode, out var code))
            {
                MessageBox.Show("Please input correct data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (carWorkshop.AddWorkshop(name, mark, city, code, country))
            {
                ClearWorkshopInputData();
            }
            else
            {
                MessageBox.Show("Workshop with same Name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearWorkshopInputData()
        {
            wshopName_textBox.Clear();
            wshopTrademark_textBox.Clear();
            wshopCity_textBox.Clear();
            wshopPostal_textBox.Clear();
            wshopCountry_textBox.Clear();
        }

        private void createApp_button_Click(object sender, EventArgs e)
        {
            string user = appCar_comboBox.Text;
            string company = appCompany_comboBox.Text;
            string car = appCar_comboBox.Text;
            DateTime date = appDate.Value;

            if (string.IsNullOrWhiteSpace(user) ||
                string.IsNullOrWhiteSpace(company) ||
                string.IsNullOrWhiteSpace(car) ||
                date < DateTime.Now)
            {
                MessageBox.Show("Please input correct data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Appointment app = new Appointment(user, company, car, date);
            carWorkshop.Appointments.Add(app);
        }
    }
}
