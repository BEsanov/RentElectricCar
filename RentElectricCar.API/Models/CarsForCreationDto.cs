using RentElectricCar.API.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentElectricCar.API.Models
{
    [ValidCarBrandName] //This code takes care of CarBrandName validation 
    public class CarsForCreationDto
    {
        [Required]
        [MaxLength(150)]
        public string CarBrandName { get; set; }
        [Required]
        [MaxLength(100)]
        public string ColorName { get; set; }
        [Required]
        [Range(0, 500000)]
        public int MileAge { get; set; }
        [Required]
        public DateTimeOffset ProductionDate { get; set; }
        [Required]
        [Range(0, 10)]
        public int NumberOfDoors { get; set; }
        [Required]
        [Range(0, 10)]
        public int NumberOfSeats { get; set; }


    }
}
