using CarRental.FormApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFormApp
{
    public partial class MainFormApp : Form
    {
        public MainFormApp()
        {
            InitializeComponent();
        }


        private void BtnCustomerService_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void BtnLocationService_Click(object sender, EventArgs e)
        {
            LocationForm locationForm = new LocationForm();
            locationForm.ShowDialog();
        }

        private void BtnReservationService_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.ShowDialog();
        }

        private void BtnVehichleService_Click(object sender, EventArgs e)
        {
            VehichleForm vehichleForm = new VehichleForm();
            vehichleForm.ShowDialog();
        }
    }
}
