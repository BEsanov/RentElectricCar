using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentElectricCar.API.Models
{
    public class CarsForCreationDto:IValidatableObject
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


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            //need improvement here 
            if (CarBrandName==null)
            {
                yield return new ValidationResult("Provide Car Brand name.",
                    new[] { "CarsForCreationDto" }); 
            }   
        }
    }
}
