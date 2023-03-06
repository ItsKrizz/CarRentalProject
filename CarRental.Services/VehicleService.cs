using CarRental.Data;
using CarRental.Models;
using System.Collections.Generic;
using System.Linq;

namespace CarRental.Services
{
    public class VehicleService
    {
        private readonly AppDbContext _context;

        public VehicleService(AppDbContext context)
        {
            _context = context;
        }

        public Vehicle GetVehicleById(int id)
        {
            return _context.Vehicles.Find(id);
        }

        public List<Vehicle> GetAllVehicles()
        {
            return _context.Vehicles.ToList();
        }

        public Vehicle AddVehicle(string make, string model, int year)
        {
            var vehicle = new Vehicle
            {
                Make = make,
                Model = model,
                Year = year
            };

            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();

            return vehicle;
        }
    }
}


