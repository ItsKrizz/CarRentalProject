using CarRental.Data;
using CarRental.Models;
using System.Collections.Generic;
using System.Linq;

namespace CarRental.Services
{
    public class CustomerService
    {
        private readonly AppDbContext _context;

        public CustomerService(AppDbContext context)
        {
            _context = context;
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customers.Find(id);
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer AddCustomer(string name, string email, string phoneNumber)
        {
            var customer = new Customer
            {
                Name = name,
                Email = email,
                PhoneNumber = phoneNumber
            };

            _context.Customers.Add(customer);
            _context.SaveChanges();

            return customer;
        }
    }
}


