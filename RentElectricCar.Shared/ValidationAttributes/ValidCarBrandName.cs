using RentElectricCar.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentElectricCar.Shared.ValidationAttributes
{
    public class ValidCarBrandName : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var car = (CarsForCreationDto)validationContext.ObjectInstance;
            if (car.CarBrandName == null)
            {
                return new ValidationResult("Car brand name must provided.",
                    new[] { nameof(CarsForCreationDto) });
            }

            if (car.CarBrandName.Length <= 2)
            {
                return new ValidationResult("Enter valid car name",
                    new[] { nameof(CarsForCreationDto) });
            }


            return ValidationResult.Success;
        }


    }

}
