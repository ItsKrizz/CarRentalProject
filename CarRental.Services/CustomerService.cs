using CarRental.Data;
using CarRental.Models;
using System.Collections.Generic;
using System.Linq;

namespace CarRental.Services
{
    public class CustomerService
    {
        private readonly AppDbContext context;

        public Customer GetCustomerById(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.Customers.Find(id);
            }
        }

        public List<Customer> GetAllCustomers()
        {
            using (var context = new AppDbContext())
            {
                return context.Customers.ToList();
            }
        }

        public Customer AddCustomer(string name, string email, string phoneNumber)
        {
            using (var context = new AppDbContext())
            {
                var customer = new Customer()
                {
                    Name = name,
                    Email = email,
                    PhoneNumber = phoneNumber
                };

                context.Customers.Add(customer);
                context.SaveChanges();

                return customer;
            }
        }
    }
}
