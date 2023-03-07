using CarRental.Data;
using CarRental.Models;
using CarRental.Services;
using System;

namespace CarRental.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the AppDbContext
            using (var context = new AppDbContext())
            {
                // Create a new instance of each service, passing in the AppDbContext
                var vehicleService = new VehicleService();
                var customerService = new CustomerService();
                var locationService = new LocationService();
                var reservationService = new ReservationService();

                // Use the services to add data to the database
                var vehicle = vehicleService.AddVehicle("Toyota", "Camry", 2020);
                var customer = customerService.AddCustomer("John Doe", "johndoe@email.com", "555-555-5555");
                var location = locationService.AddLocation("123 Main St.");
                var reservation = reservationService.AddReservation(DateTime.Now, DateTime.Now.AddDays(7), vehicle.Id, customer.Id);

                // Use the services to retrieve data from the database
                var allVehicles = vehicleService.GetAllVehicles();
                var allCustomers = customerService.GetAllCustomers();
                var allLocations = locationService.GetAllLocations();
                var reservationById = reservationService.GetReservationById(reservation.Id);
                var reservationsByCustomerId = reservationService.GetReservationsByCustomerId(customer.Id);
                var reservationsByVehicleId = reservationService.GetReservationsByVehicleId(vehicle.Id);

                // Output the data retrieved from the database
                Console.WriteLine("All Vehicles:");
                foreach (var v in allVehicles)
                {
                    Console.WriteLine($"ID: {v.Id}, Make: {v.Make}, Model: {v.Model}, Year: {v.Year}");
                }

                Console.WriteLine();

                Console.WriteLine("All Customers:");
                foreach (var c in allCustomers)
                {
                    Console.WriteLine($"ID: {c.Id}, Name: {c.Name}, Email: {c.Email}, Phone Number: {c.PhoneNumber}");
                }

                Console.WriteLine();

                Console.WriteLine("All Locations:");
                foreach (var l in allLocations)
                {
                    Console.WriteLine($"ID: {l.Id}, Address: {l.Address}");
                }

                Console.WriteLine();

                Console.WriteLine($"Reservation with ID {reservationById.Id}:");
                Console.WriteLine($"Start Date: {reservationById.StartDate}, End Date: {reservationById.EndDate}");
                Console.WriteLine($"Vehicle: {reservationById.Vehicle.Make} {reservationById.Vehicle.Model} ({reservationById.Vehicle.Year})");
                Console.WriteLine($"Customer: {reservationById.Customer.Name} ({reservationById.Customer.Email}, {reservationById.Customer.PhoneNumber})");

                Console.WriteLine();

                Console.WriteLine($"Reservations for customer {customer.Name}:");
                foreach (var r in reservationsByCustomerId)
                {
                    Console.WriteLine($"ID: {r.Id}, Vehicle: {r.Vehicle.Make} {r.Vehicle.Model}, Start Date: {r.StartDate}, End Date: {r.EndDate}");
                }

                Console.WriteLine();

                Console.WriteLine($"Reservations for vehicle {vehicle.Make} {vehicle.Model}:");
                foreach (var r in reservationsByVehicleId)
                {
                    Console.WriteLine($"ID: {r.Id}, Customer: {r.Customer.Name} ({r.Customer.Email}, {r.Customer.PhoneNumber}), Start Date: {r.StartDate}, End Date: {r.EndDate}");
                }
            }
        }
    }
}