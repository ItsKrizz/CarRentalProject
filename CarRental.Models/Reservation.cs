namespace CarRental.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Reservation
    {
        public Reservation() { } 
        public Reservation(Customer customer, Location location, DateTime startDate)
        {
            Customer = customer;
            StartDate = startDate;
        }
        public Location Location { get; set; }

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
