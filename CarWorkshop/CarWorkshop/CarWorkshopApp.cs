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
            carWorkshop.AddUser("Ivan", "Ivanov", "NY city", "12300", "USA");
            carWorkshop.AddUser("John", "Smith", "kyiv", "54300", "Ukraine");

            carWorkshop.AddWorkshop("STO", "BMW", "kiev", "000111", "UK");
            carWorkshop.AddWorkshop("STO 2", "VW", "Borispol", "04011", "UA");

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

            if(carWorkshop.AddUser(name, email, city, postalCode, country))
            {
                ClearUserInputData();
            }
            else
            {
                MessageBox.Show("Please input correct data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

            if (carWorkshop.AddWorkshop(name, mark, city, postalCode, country))
            {
                ClearWorkshopInputData();
            }
            else
            {
                MessageBox.Show("Please input correct data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

            if(!carWorkshop.CreateAppoitment(user, company, car, date))
            { 
                MessageBox.Show("Please input correct data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            workshops_dataGridView.DataSource = carWorkshop.GetWorkshopsForCity(cityFilter_textBox.Text);
        }

        private void wshopResetFilter_button_Click(object sender, EventArgs e)
        {
            workshops_dataGridView.DataSource = carWorkshop.Workshops;
            cityFilter_textBox.Clear();
        }
    }
}
