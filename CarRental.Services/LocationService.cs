using CarRental.Data;
using CarRental.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CarRental.Services
{
    public class LocationService
    {
        private readonly AppDbContext context;

        public Location GetLocationById(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.Locations.Find(id);
            }
        }

        public List<Location> GetAllLocations()
        {
            using (var context = new AppDbContext())
            {
                return context.Locations.ToList();
            }
        }

        public Location AddLocation(string name,string address)
        {
            using (var context = new AppDbContext())
            {
                var location = new Location(name,address);
                {
                    context.Locations.Add(location);
                    context.SaveChanges();

                    return location;
                };
            }
        }
    }
}
