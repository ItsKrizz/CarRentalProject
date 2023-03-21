using CarRental.Data;
using CarRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRental.Services
{
    public class VehicleService
    {
        private readonly AppDbContext context;

        public Vehicle GetVehicleById(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.Vehicles.Find(id);
            }
        }

        public List<Vehicle> GetAllVehicles()
        {
            using (var context = new AppDbContext())
            {
                return context.Vehicles.ToList();
            }
        }

        public Vehicle AddVehicle(string make, string model, int year)
        {
            using (var context = new AppDbContext())
            {
                var vehicle = new Vehicle
                {
                    Make = make,
                    Model = model,
                    Year = year
                };

                context.Vehicles.Add(vehicle);
                context.SaveChanges();

                return vehicle;
            }
        }

        public List<Vehicle> GetAvailableVehicles(DateTime startDate, DateTime endDate)
        {
            using (var context = new AppDbContext())
            {
                var reservedVehicleIds = context.Reservations
                    .Where(r => (r.StartDate <= startDate && r.EndDate >= startDate)
                        || (r.StartDate <= endDate && r.EndDate >= endDate)
                        || (r.StartDate >= startDate && r.EndDate <= endDate))
                    .Select(r => r.VehicleId)
                    .ToList();

                return context.Vehicles
                    .Where(v => !reservedVehicleIds.Contains(v.Id))
                    .ToList();
            }
        }

        public void DeleteVehicle(int id)
        {
            using (var context = new AppDbContext())
            {
                var vehicle = context.Vehicles.Find(id);

                if (vehicle == null)
                {
                    return;
                }

                context.Vehicles.Remove(vehicle);
                context.SaveChanges();
            }
        }
    }
}
