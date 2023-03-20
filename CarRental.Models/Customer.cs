namespace CarRental.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.ComponentModel.DataAnnotations;
    public class Customer
    {
        public Customer() { }
        public Customer(string name, string email, string phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }

        public override string ToString()
        {
            return $"|Name: {Name} | Email: {Email} | Phone Number: {PhoneNumber}|";
        }
    }
}
