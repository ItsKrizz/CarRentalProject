using CarRental.Models;
using CarRental.Services;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerService customerService = new CustomerService();
            LocationService locationService = new LocationService();
            ReservationService reservationService = new ReservationService();
            VehicleService vehicleService = new VehicleService();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Welcome to the car rental system!");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Add customer");
                Console.WriteLine("2 - Add location");
                Console.WriteLine("3 - List all customers");
                Console.WriteLine("4 - List all locations");
                Console.WriteLine("5 - List all vehicles");
                Console.WriteLine("6 - List all reservations");

                Console.Write("Enter your choice: ");
                string choiceString = Console.ReadLine();

                if (!int.TryParse(choiceString, out int choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 0 and 7.");
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        exit = true;
                        Console.WriteLine("Exiting the reservation system...");
                        break;
                    case 1:
                        AddCustomer(customerService);
                        break;
                    case 2:
                        AddLocation(locationService);
                        break;
                    case 3:
                        ListAllCustomers(customerService);
                        break;
                    case 4:
                        ListAllLocations(locationService);
                        break;
                    case 5:
                        ListAllVehicles(vehicleService);
                        break;
                    case 6:
                        ListAllReservations(reservationService); break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 0 and 6.");
                        break;
                }
                static void ListAllReservations(ReservationService reservationService)
                {
                    var reservations = reservationService.GetAllReservations();

                    Console.WriteLine("Start Date\t\tEnd Date");
                    Console.WriteLine("---------------------------------------------------------------");

                    foreach (var reservation in reservations)
                    {
                        Console.WriteLine($"{reservation.StartDate.ToShortDateString()}\t\t{reservation.EndDate.ToShortDateString()}");
                    }
                }
                static void ListAllVehicles(VehicleService vehicleService)
                {
                    var vehicles = vehicleService.GetAllVehicles();

                    Console.WriteLine("{0,-15} {1,-15} {2,-10}", "Make", "Model", "Year");
                    Console.WriteLine("---------------------------------------------");
                    foreach (var vehicle in vehicles)
                    {
                        Console.WriteLine("{0,-15} {1,-15} {2,-10}", vehicle.Make, vehicle.Model, vehicle.Year);
                    }
                }
                static void ListAllLocations(LocationService locationService)
                {
                    var locations = locationService.GetAllLocations();

                    Console.WriteLine("{0,-20} | {1,-30}", "Town", "Address");
                    Console.WriteLine("--------------------------------+---------------------------------");

                    foreach (var location in locations)
                    {
                        Console.WriteLine("{0,-20} | {1,-30}", location.Name, location.Address);
                    }
                }
                static void ListAllCustomers(CustomerService customerService)
                {
                    var customers = customerService.GetAllCustomers();

                    Console.WriteLine("| {0,-10} | {1,-20} | {2,-30} | {3,-15} |", "ID", "Name", "Email", "Phone Number");
                    Console.WriteLine("|{0,-12}|{1,-22}|{2,-32}|{3,-17}|", new string('-', 12), new string('-', 22), new string('-', 32), new string('-', 17));

                    foreach (var customer in customers)
                    {
                        Console.WriteLine("| {0,-10} | {1,-20} | {2,-30} | {3,-15} |", customer.Id, customer.Name, customer.Email, customer.PhoneNumber);
                    }
                }
                static void AddReservation(ReservationService reservationService)
                {
                    Console.WriteLine("Adding a new reservation...");

                    Console.Write("Enter the reservation customer's ID: ");
                    int customerId = int.Parse(Console.ReadLine());

                    Console.Write("Enter the reservation start date (yyyy-mm-dd): ");
                    string startDateString = Console.ReadLine();
                    DateTime startDate = DateTime.ParseExact(startDateString, "yyyy-MM-dd", null);

                    Console.Write("Enter the reservation end date (yyyy-mm-dd): ");
                    string endDateString = Console.ReadLine();
                    DateTime endDate = DateTime.ParseExact(endDateString, "yyyy-MM-dd", null);

                    Console.Write("Enter the vehicle's ID: ");
                    int vehicleId = int.Parse(Console.ReadLine());

                    reservationService.AddReservation(startDate, endDate, vehicleId, customerId);

                    Console.WriteLine("Reservation added successfully.");
                }
                static void AddCustomer(CustomerService customerService)
                {
                    Console.WriteLine("Adding a new customer...");

                    Console.Write("Enter the customer's name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter the customer's email: ");
                    string email = Console.ReadLine();

                    Console.Write("Enter the customer's phone number: ");
                    string phoneNumber = Console.ReadLine();

                    customerService.AddCustomer(name, email, phoneNumber);

                    Console.WriteLine("Customer added successfully.");
                }
                static void AddLocation(LocationService locationService)
                {
                    Console.WriteLine("Adding a new location...");

                    Console.Write("Enter the location name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter the location address: ");
                    string address = Console.ReadLine();

                    locationService.AddLocation(name, address);

                    Console.WriteLine("Location added successfully.");
                }
            }
        }
    }
}