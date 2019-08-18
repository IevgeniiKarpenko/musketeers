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
        private CarWorkshop carWorkshop;
        private List<string> cars;

        public CarWorkshopApp()
        {
            InitializeComponent();

            carWorkshop = new CarWorkshop();
            cars = new List<string>();

            carWorkshop.Users.Add("Tete", new User("sad", "asda", "city", 123, "aasd"));
            appUsr_comboBox.DataSource = carWorkshop.Users.Keys.ToList();

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
                UpdateAppoitmentComboboxes();
            }
            else
            {
                MessageBox.Show("User with same Name or Email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateAppoitmentComboboxes()
        {
            appUsr_comboBox.DataSource = carWorkshop.Users.Keys.ToList();
            appCompany_comboBox.DataSource = carWorkshop.Workshops.Keys.ToList();
            appCar_comboBox.DataSource = cars.ToList();
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
                cars.Add(mark);
                ClearWorkshopInputData();
                UpdateAppoitmentComboboxes();
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

        private void deleteUser_button_Click(object sender, EventArgs e)
        {

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
