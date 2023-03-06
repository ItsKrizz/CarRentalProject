namespace CarRental.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.ComponentModel.DataAnnotations;
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int ReservationId { get; set; }
        public  virtual Reservation Reservation { get; set; }
    }
}
