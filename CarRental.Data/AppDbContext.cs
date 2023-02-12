using Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;


namespace CarRental.Data
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Server=DESKTOP-LVCQ3HO; Initial Catalog=CarRentalEf; Integrated Security=true; Trusted_Connection=true";
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Insurance> Insurances { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<FlightDestination> FlightDestinations { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Pilot> Pilots { get; set; }
        public virtual DbSet<PilotAircraft> PilotsAircraft { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
