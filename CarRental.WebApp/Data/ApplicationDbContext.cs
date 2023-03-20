using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarRental.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CarRental.WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        private const string ConnectionString = @"Server=MIRKO-PC\SQLEXPRESS; Initial Catalog=CarRentalEf; Integrated Security=true; Trusted_Connection=true";
        public DbSet<CarRental.Models.Vehicle>? Vehicles { get; set; }

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder, string ConnectionString)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        optionsBuilder.UseLazyLoadingProxies();
    }

    
}