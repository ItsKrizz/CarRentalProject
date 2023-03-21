using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CarRental.Models;
using CarRental.Services;
namespace CarRental.FormApp
{
    public partial class VehichleForm : Form
    {
        private readonly VehicleService _vehicleService;
        public VehichleForm()
        {
            InitializeComponent();
            _vehicleService = new VehicleService();

            List<Vehicle> vehicles = _vehicleService.GetAllVehicles();

            foreach (Vehicle vehicle in vehicles)
            {
                listBox2.Items.Add(vehicle);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VehichleForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vehicleId;

            if (!int.TryParse(textBox1.Text, out vehicleId))
            {
                MessageBox.Show("Invalid vehicle ID", "Input Error");
                return;
            }

            var vehicleService = new VehicleService();
            var vehicle = vehicleService.GetVehicleById(vehicleId);

            if (vehicle == null)
            {
                MessageBox.Show("Vehicle with ID " + vehicleId + " does not exist", "Input Error");
                return;
            }

            vehicleService.DeleteVehicle(vehicleId);

            MessageBox.Show("Vehicle deleted successfully", "Success");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int id))
            {
                var vehicle = _vehicleService.GetVehicleById(id);
                if (vehicle != null)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add($"{vehicle.Make} {vehicle.Model} ({vehicle.Year})");
                }
                else
                {
                    MessageBox.Show("No vehicle found with the specified ID.", "Search Result");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer ID.", "Input Error");
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string make = textBox3.Text;
            string model = textBox4.Text;
            if (int.TryParse(textBox5.Text, out int year))
            {
                var vehicle = _vehicleService.AddVehicle(make, model, year);
                MessageBox.Show($"Vehicle added successfully with ID: {vehicle.Id}", "Success");
            }
            else
            {
                MessageBox.Show("Please enter a valid integer year.", "Input Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
