using CarRental.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CarRental.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRental.FormApp
{
    public partial class LocationForm : Form
    {
        private readonly LocationService _locationService;
        public LocationForm()
        {
            InitializeComponent();
            _locationService = new LocationService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string town = textBox1.Text;
            string address = textBox2.Text;

            if (town.Length < 2)
            {
                MessageBox.Show("Invalid Town/Village", "Input Error");
                return;
            }

            if (address.Length < 3)
            {
                MessageBox.Show("Invalid Address", "Input Error");
                return;
            }


            var locationService = new LocationService();
            locationService.AddLocation(town, address);

            MessageBox.Show("Location added successfully", "Success");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LocationForm_Load(object sender, EventArgs e)
        {
            var locations = _locationService.GetAllLocations();
            foreach (var location in locations)
            {
                listBox1.Items.Add(location);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(textBox3.Text, out id))
            {
                var location = _locationService.GetLocationById(id);
                if (location != null)
                {
                    listBox2.Items.Clear();
                    listBox2.Items.Add(location);
                }
                else
                {
                    MessageBox.Show("No location found with the specified ID.", "Search Result");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer ID.", "Input Error");
            }
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
