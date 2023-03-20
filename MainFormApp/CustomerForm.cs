using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CarRental.Services;

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
            var customers = _customerService.GetAllCustomers(); // get all the customers
            foreach (var customer in customers)
            {
                listBox1.Items.Add(customer); // add each customer to the list box
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // handle the selected index changed event if needed
        }
    }
}
