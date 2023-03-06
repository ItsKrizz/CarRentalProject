
using CarRental.Data;
using CarRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRental.Services

{
    public class CarRentalService
    {
        private readonly AppDbContext _context;

        public CarRentalService(AppDbContext context)
        {
            _context = context;
        }

        // Method to create a new reservation
        public Reservation CreateReservation(Customer customer, Vehicle vehicle, DateTime pickupDate, DateTime returnDate, Location pickupLocation, Location returnLocation)
        {
            // Create a new reservation object with the given parameters
            Reservation reservation = new Reservation()
            {
                Customer = customer,
                Vehicle = vehicle,
            };

            // Add the reservation to the database and save changes
            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            return reservation;
        }
       

        // Method to get a customer's reservation history
        public List<Reservation> GetReservationHistory(Customer customer)
        {
            // Find all reservations for the given customer
            var reservations = _context.Reservations
                .Where(r => r.Customer == customer)
                .ToList();

            return reservations;
        }

        // Method to create a new vehicle
        public Vehicle CreateVehicle(string make, string model, int year, string type, int dailyRate)
        {
            // Get the VehicleType object with the given type name
            VehicleType vehicleType = _context.VehicleTypes.FirstOrDefault(vt => vt.Name == type);

            // Create a new vehicle object with the given parameters
            Vehicle vehicle = new Vehicle()
            {
                Make = make,
                Model = model,
                Year = year,
            };

            // Add the vehicle to the database and save changes
            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();

            return vehicle;
        }

        // Method to get all vehicles in the database
        public List<Vehicle> GetAllVehicles()
        {
            var vehicles = _context.Vehicles.ToList();
            return vehicles;
        }
    }
}
