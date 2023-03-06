using CarRental.Data;
using CarRental.Models;
using System.Collections.Generic;
using System.Linq;

namespace CarRental.Services
{
    public class LocationService
    {
        private readonly AppDbContext _context;

        public LocationService(AppDbContext context)
        {
            _context = context;
        }

        public Location GetLocationById(int id)
        {
            return _context.Locations.Find(id);
        }

        public List<Location> GetAllLocations()
        {
            return _context.Locations.ToList();
        }

        public Location AddLocation(string address)
        {
            var location = new Location
            {
                Address = address
            };

            _context.Locations.Add(location);
            _context.SaveChanges();

            return location;
        }
    }
}


