using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentElectricCar.API.Entities
{
    public class Car
    {
        [Key]
        public Guid CarId { get; set; }
        [Required]
        [MaxLength(100)]
        public string ColorName { get; set; }

        [Required]
        [Range(0, 500000)]
        public int MileAge { get; set; }
        [Required]
        [MaxLength(100)]
        public string Transmission { get; set; }
        [Required]
        public DateTimeOffset ProductionDate { get; set; }

        [Required]
        [Range(0, 10)]
        public int NumberOfDoors { get; set; }
        [Required]
        [Range(0, 10)]
        public int NumberOfSeats { get; set; }

        [ForeignKey("LocationId")]
        public Location Location { get; set; }

        public Guid LocationId { get; set; }
    }
}
