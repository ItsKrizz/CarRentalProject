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
                Console.WriteLine("Welcome to the reservation system!");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Add customer");
                Console.WriteLine("2 - Add location");

                Console.Write("Enter your choice: ");
                string choiceString = Console.ReadLine();

                if (!int.TryParse(choiceString, out int choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 0 and 6.");
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
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 0 and 6.");
                        break;
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

                    Console.Write("Enter the location's name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter the location's address: ");
                    string address = Console.ReadLine();

                    Location location = new Location(name, address);
                    locationService.AddLocation(name, address);

                    Console.WriteLine("Location added successfully.");
                }
            }
        }
    }
}