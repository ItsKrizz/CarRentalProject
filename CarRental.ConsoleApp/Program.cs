using CarRental.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();
        static List<Location> locations = new List<Location>();
        static List<Reservation> reservations = new List<Reservation>();

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Welcome to the reservation system!");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Add customer");
                Console.WriteLine("2 - Add location");
                Console.WriteLine("3 - Add reservation");
                Console.WriteLine("4 - View customers");
                Console.WriteLine("5 - View locations");
                Console.WriteLine("6 - View reservations");

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
                        AddCustomer();
                        break;
                    case 2:
                        AddLocation();
                        break;
                    case 3:
                        AddReservation();
                        break;
                    case 4:
                        ViewCustomers();
                        break;
                    case 5:
                        ViewLocations();
                        break;
                    case 6:
                        ViewReservations();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 0 and 6.");
                        break;
                }

                static void AddCustomer()
                {
                    Console.WriteLine("Adding a new customer...");

                    Console.Write("Enter the customer's name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter the customer's email: ");
                    string email = Console.ReadLine();

                    Console.Write("Enter the customer's phone number: ");
                    string phoneNumber = Console.ReadLine();

                    Customer customer = new Customer(name, email,phoneNumber);
                    customers.Add(customer);

                    Console.WriteLine("Customer added successfully.");
                }

                static void AddLocation()
                {
                    Console.WriteLine("Adding a new location...");

                    Console.Write("Enter the location's name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter the location's address: ");
                    string address = Console.ReadLine();

                    Location location = new Location(name, address);
                    locations.Add(location);

                    Console.WriteLine("Location added successfully.");
                }

                static void AddReservation()
                {
                    Console.WriteLine("Adding a new reservation...");

                    Console.Write("Enter the customer's email: ");
                    string email = Console.ReadLine();

                    Customer customer = customers.Find(c => c.Email == email);
                    if (customer == null)
                    {
                        Console.WriteLine("Customer not found. Please add the customer first.");
                        return;
                    }

                    Console.Write("Enter the location's name: ");
                    string locationName = Console.ReadLine();

                    Location location = locations.Find(l => l.Name == locationName);
                    if (location == null)
                    {
                        Console.WriteLine("Location not found. Please add the location first.");
                        return;
                    }

                    Console.Write("Enter the reservation date (yyyy-MM-dd): ");
                    string dateString = Console.ReadLine();
                    DateTime date;
                    if (!DateTime.TryParse(dateString, out date))
                    {
                        Console.WriteLine("Invalid date format. Please enter the date in yyyy-MM-dd format.");
                        return;
                    }

                    Reservation reservation = new Reservation(customer, location, date);
                    reservations.Add(reservation);

                    Console.WriteLine("Reservation added successfully.");
                }

                static void ViewCustomers()
                {
                    Console.WriteLine("List of customers:");

                    foreach (Customer customer in customers)
                    {
                        Console.WriteLine($"Name: {customer.Name}, Email: {customer.Email}");
                    }

                    Console.WriteLine();
                }

                static void ViewLocations()
                {
                    Console.WriteLine("List of locations:");
                    foreach (Location location in locations)
                    {
                        Console.WriteLine($"Name: {location.Name}, Address: {location.Address}");
                    }

                    Console.WriteLine();
                }

                static void ViewReservations()
                {
                    Console.WriteLine("List of reservations:");

                    foreach (Reservation reservation in reservations)
                    {
                        Console.WriteLine($"Customer: {reservation.Customer.Name} ({reservation.Customer.Email})");
                        Console.WriteLine($"Location: {reservation.Location.Name} ({reservation.Location.Address})");
                        Console.WriteLine($"Date: {reservation.StartDate.ToString("yyyy-MM-dd")}");
                        Console.WriteLine();
                    }
                }

            }
        }
    }
}