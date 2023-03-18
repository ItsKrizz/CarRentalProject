using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using CarRental.Services;
namespace CarRental.Seeder
{
    public class Program
    {
        private static CustomerService customerService = new CustomerService();
        private static VehicleService vehicleService = new VehicleService();
        private static LocationService locationService = new LocationService();
        public static ReservationService reservationService = new ReservationService();
        public static void Main()
        {
            //SeedCustomers(100);
            //SeedVehicles(100);
            //SeedLocations(100);
            SeedReservations(100);
        }

        public static void SeedReservations(int reservationCount)
        {

            List<int> vehicleId = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> customerId = new List<int>() {1,2,3,4,5,6,7,8};
            List<DateTime> reservationStartDates = new List<DateTime>();
            List<DateTime> reservationEndDates = new List<DateTime>();

            for (int i = 0; i < reservationCount; i++)
            {

                Random random = new Random();

                DateTime start = new DateTime(2022, 1, 1);
                int range = (DateTime.Today - start).Days;
                DateTime startDate = start.AddDays(random.Next(range));
                DateTime endDate = startDate.AddDays(random.Next(1, 14));
                reservationStartDates.Add(startDate);
                reservationEndDates.Add(endDate);

                int vehicleIdCount = random.Next(0, vehicleId.Count);
                int customerIdCount = random.Next(0, customerId.Count);

                Console.WriteLine(reservationService.AddReservation(reservationStartDates[i], reservationEndDates[i], vehicleId[vehicleIdCount], customerId[customerIdCount]));
            }

        }
        public static void SeedLocations(int locationCounts)
        {
            List<string> name = new List<string>() { "Dorkovo", "Draginovo", "Velingrad", "Kostandovo", "Sofia" };
            List<string> address = new List<string>() { "Peyo Yavorov 3", "Ivan Vazov 4", "Kristal 5", "Rodzhen 1", "Pencho Slaveikov 5", " Ivan Rilski 6" };

            Random random = new Random();

            for (int i = 0; i < locationCounts; i++)
            {
                int makeCount = random.Next(0, name.Count);
                int modelCount = random.Next(0, address.Count);

                Console.WriteLine(locationService.AddLocation(name[makeCount], address[modelCount]));
            }
        }
        public static void SeedVehicles(int vehicleCount)
        {
            List<string> make = new List<string>() { "BMW", "Mercedes", "Audi", "Mazda", "Opel" };
            List<string> model = new List<string>() { "Astra", "320", "C220", "S500", "RS6", "6" };
            List<int> year = new List<int> { 2005, 2006, 2007, 2012, 2014, 1999, 1987 };

            Random random = new Random();

            for (int i = 0; i < vehicleCount; i++)
            {
                int makeCount = random.Next(0, make.Count);
                int modelCount = random.Next(0, model.Count);
                int yearCount = random.Next(0, year.Count);
                Console.WriteLine(vehicleService.AddVehicle(make[makeCount], model[modelCount], year[yearCount]));
            }
        }
        public static void SeedCustomers(int customerCount)
        {
            List<string> firstName = new List<string>() { "Jane", "Lenore", "Susy", "Genna", "Viki", "Toni" };
            List<string> email = new List<string>() { "jane@abv.bg", "lenore@abv.bg", "susy@gmail.com", "genna@yahoo.com", "spicyboy@gmail.com", "codeman@abv.bg" };
            List<string> phoneNumber = new List<string> { "(567) 890-1234", "(555) 555-5555", "(123) 456-7890", "(987) 654-3210", "(555) 123-4567", "(888) 555-1212" };
            Random random = new Random();

            for (int i = 0; i < customerCount; i++)
            {
                int customerFirstNameIndex = random.Next(0, firstName.Count);
                int customerEmailIndex = random.Next(0, email.Count);
                int customerPhoneNumberIndex = random.Next(0, phoneNumber.Count);
                Console.WriteLine(customerService.AddCustomer(firstName[customerFirstNameIndex], email[customerEmailIndex], phoneNumber[customerPhoneNumberIndex]));
            }
        }
    }

}

