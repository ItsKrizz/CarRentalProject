namespace CarRental.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; }
    }
}
