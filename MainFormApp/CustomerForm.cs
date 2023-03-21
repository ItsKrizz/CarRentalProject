using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CarRental.Services;
using CarRental.FormApp;

namespace CarRental.FormApp
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerService _customerService;

        public CustomerForm()
        {
            InitializeComponent();
            _customerService = new CustomerService();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            var customers = _customerService.GetAllCustomers();
            foreach (var customer in customers)
            {
                listBox1.Items.Add(customer);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(textBox1.Text, out id))
            {
                var customer = _customerService.GetCustomerById(id);
                if (customer != null)
                {
                    listBox2.Items.Clear();
                    listBox2.Items.Add(customer);
                }
                else
                {
                    MessageBox.Show("No customer found with the specified ID.", "Search Result");
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

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string email = textBox4.Text;
            string phoneNumber = textBox3.Text;

            if (name.Length < 2)
            {
                MessageBox.Show("Invalid name", "Input Error");
                return;
            }

            if (phoneNumber.Length < 6)
            {
                MessageBox.Show("Invalid phone number", "Input Error");
                return;
            }

            if (email.Length == 0)
            {
                MessageBox.Show("Invalid email", "Input Error");
                return;
            }

            var customerService = new CustomerService();
            customerService.AddCustomer(name, email, phoneNumber);

            MessageBox.Show("Customer added successfully", "Success");
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide the current form

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
