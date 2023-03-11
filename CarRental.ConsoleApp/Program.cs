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
            using (var context = new AppDbContext())
            {
                // Adding a new customer
                var customerService = new CustomerService();
                var customer = customerService.AddCustomer("John Doe", "johndoe@example.com", "1234567890");
                Console.WriteLine($"Customer with ID {customer.Id} has been added.");

                // Adding a new location
                var locationService = new LocationService();
                var location = locationService.AddLocation("123 Main St");
                Console.WriteLine($"Location with ID {location.Id} has been added.");

                // Adding a new vehicle
                var vehicleService = new VehicleService();
                var vehicle = vehicleService.AddVehicle("Toyota", "Camry", 2021);
                Console.WriteLine($"Vehicle with ID {vehicle.Id} has been added.");

                // Adding a new reservation
                var reservationService = new ReservationService();
                var startDate = DateTime.Today.AddDays(1);
                var endDate = DateTime.Today.AddDays(7);
                var reservation = reservationService.AddReservation(startDate, endDate, vehicle.Id, customer.Id);
                Console.WriteLine($"Reservation with ID {reservation.Id} has been added.");

                // Retrieving a customer by ID
                var retrievedCustomer = customerService.GetCustomerById(customer.Id);
                Console.WriteLine($"Retrieved customer: {retrievedCustomer.Name}");

                // Retrieving all customers
                var allCustomers = customerService.GetAllCustomers();
                Console.WriteLine($"Number of customers: {allCustomers.Count}");

                // Retrieving a location by ID
                var retrievedLocation = locationService.GetLocationById(location.Id);
                Console.WriteLine($"Retrieved location: {retrievedLocation.Address}");

                // Retrieving all locations
                var allLocations = locationService.GetAllLocations();
                Console.WriteLine($"Number of locations: {allLocations.Count}");

                // Retrieving a vehicle by ID
                var retrievedVehicle = vehicleService.GetVehicleById(vehicle.Id);
                Console.WriteLine($"Retrieved vehicle: {retrievedVehicle.Make} {retrievedVehicle.Model}");

                // Retrieving all vehicles
                var allVehicles = vehicleService.GetAllVehicles();
                Console.WriteLine($"Number of vehicles: {allVehicles.Count}");

                // Retrieving all reservations for a customer
                var customerReservations = reservationService.GetReservationsByCustomerId(customer.Id);
                Console.WriteLine($"Number of reservations for customer: {customerReservations.Count}");

                // Retrieving all reservations for a vehicle
                var vehicleReservations = reservationService.GetReservationsByVehicleId(vehicle.Id);
                Console.WriteLine($"Number of reservations for vehicle: {vehicleReservations.Count}");

                // Retrieving all available vehicles for a given date range
                var availableVehicles = vehicleService.GetAvailableVehicles(startDate, endDate);
                Console.WriteLine($"Number of available vehicles: {availableVehicles.Count}");
            }
        }
    }
}
