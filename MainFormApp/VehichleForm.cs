using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            var listBoxItem = listBox2.Items.Cast<Vehicle>()
                                       .FirstOrDefault(v => v.Id == vehicleId);
            if (listBoxItem != null)
            {
                listBox2.Items.Remove(listBoxItem);
            }
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

                listBox2.Items.Clear();
                List<Vehicle> vehicles = _vehicleService.GetAllVehicles();
                foreach (Vehicle v in vehicles)
                {
                    listBox2.Items.Add(v);
                }
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

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id;
            string newMake = textBox8.Text;
            string newModel = textBox6.Text; if (!int.TryParse(textBox9.Text, out id))
            {
                MessageBox.Show("Please enter a valid integer ID.", "Input Error");
                return;
            }
            if (!int.TryParse(textBox7.Text, out int newYear))
            {
                MessageBox.Show("Please enter a valid integer year.", "Input Error");
                return;
            }
            var vehicle = _vehicleService.GetVehicleById(id); if (vehicle == null)
            {
                MessageBox.Show("No vehicle found with the specified ID.", "Input Error");
                return;
            }
            _vehicleService.UpdateVehicle(id, newMake, newModel, newYear); MessageBox.Show($"Vehicle with ID {id} updated successfully.", "Success"); listBox2.Items.Clear(); List<Vehicle> vehicles = _vehicleService.GetAllVehicles(); foreach (Vehicle v in vehicles)
            {
                listBox2.Items.Add(v);
            }
            textBox8.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
