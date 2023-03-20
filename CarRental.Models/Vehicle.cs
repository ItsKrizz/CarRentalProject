namespace CarRental.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
    }
}
