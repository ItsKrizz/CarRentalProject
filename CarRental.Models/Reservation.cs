namespace CarRental.Models
{
    using Castle.Components.DictionaryAdapter;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Reservation
    {
        public Reservation(DateTime startDate, DateTime endDate, int vehicleId, int customerId) 
        {
            StartDate = startDate;
            EndDate = endDate;
            VehicleId = vehicleId;
            CustomerId = customerId;
        } 
        public Reservation(Customer customer, Location location, DateTime startDate)
        {
            Customer = customer;
            StartDate = startDate;
        }
        public virtual Location Location { get; set; }
        
        public int Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public override string ToString()
        {
            return $"Start Date: {StartDate.ToShortDateString()} | End Date: {EndDate.ToShortDateString()} | Vehicle ID: {VehicleId} | Customer ID: {CustomerId}";
        }
    }
}
