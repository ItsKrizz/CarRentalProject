using Castle.Components.DictionaryAdapter;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class Transaction
    {
        
        public int Id { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
