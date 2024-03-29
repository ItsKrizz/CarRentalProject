﻿using CarRental.Models;
using CarRental.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRental.FormApp
{
    public partial class ReservationForm : Form
    {
        private readonly ReservationService _reservationService;
        public ReservationForm()
        {
            InitializeComponent();
            _reservationService = new ReservationService();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int customerId;
            if (int.TryParse(textBox2.Text, out customerId))
            {
                var reservations = _reservationService.GetReservationsByCustomerId(customerId);
                if (reservations.Count > 0)
                {
                    listBox3.Items.Clear();
                    foreach (var reservation in reservations)
                    {
                        listBox3.Items.Add(reservation);
                    }
                }
                else
                {
                    MessageBox.Show("No reservations found for the specified customer ID.", "Search Result");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer customer ID.", "Input Error");
            }
        }


        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            var reservations = _reservationService.GetAllReservations();
            foreach (var reservation in reservations)
            {
                listBox1.Items.Add(reservation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int id))
            {
                var reservation = _reservationService.GetReservationById(id);
                if (reservation != null)
                {
                    listBox2.Items.Clear();
                    listBox2.Items.Add(reservation);
                }
                else
                {
                    MessageBox.Show("No reservation found with the specified ID.", "Search Result");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer ID.", "Input Error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox3.Text, out int vehicleId))
            {
                MessageBox.Show("Invalid input. Please enter a valid vehicle ID.", "Input Error");
                return;
            }

            var reservations = _reservationService.GetReservationsByVehicleId(vehicleId);

            listBox4.Items.Clear();
            foreach (var reservation in reservations)
            {
                listBox4.Items.Add($"Reservation ID: {reservation.Id}, Customer ID: {reservation.CustomerId}, Vehicle ID: {reservation.VehicleId}, Start Date: {reservation.StartDate.ToShortDateString()}, End Date: {reservation.EndDate.ToShortDateString()}");
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            int vehicleId;
            int customerId;

            if (!int.TryParse(textBox4.Text, out vehicleId))
            {
                MessageBox.Show("Invalid vehicle ID", "Input Error");
                return;
            }

            if (!int.TryParse(textBox5.Text, out customerId))
            {
                MessageBox.Show("Invalid customer ID", "Input Error");
                return;
            }

            var reservationService = new ReservationService();
            var reservation = reservationService.AddReservation(startDate, endDate, vehicleId, customerId);

            MessageBox.Show("Reservation added successfully", "Success");

            listBox1.Items.Clear();
            List<Reservation> reservations = reservationService.GetAllReservations();
            foreach (Reservation r in reservations)
            {
                listBox1.Items.Add(r);
            }
        }
    }
}
