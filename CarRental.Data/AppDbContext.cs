using CarRental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;


namespace CarRental.Data
{
        public class AppDbContext : DbContext
        {
            private const string ConnectionString = @"Server=DESKTOP-UACUS9A; Initial Catalog=CarRentalEf; Integrated Security=true; Trusted_Connection=true";
            public virtual DbSet<Customer> Customers { get; set; }
            public virtual DbSet<Insurance> Insurances { get; set; }
            public virtual DbSet<Location> Locations { get; set; }
            public virtual DbSet<Reservation> Reservations { get; set; }
            public virtual DbSet<Transaction> Transactions { get; set; }
            public virtual DbSet<Vehicle> Vehicles { get; set; }
            public virtual DbSet<VehicleType> VehicleTypes { get; set; }
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
