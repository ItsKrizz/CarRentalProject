namespace CarRental.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.ComponentModel.DataAnnotations;
    public class Location
    {

        public Location(string name, string address)
        {
            Name = name;
            Address = address;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Address { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Town/Village: {Name} | Address: {Address}";
        }
    }
}
