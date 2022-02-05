using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentElectricCar.API.Entities
{
    public class Location
    {
        [Key]
        public Guid LocationId { get; set; }
        [Required]
        [MaxLength(150)]
        public string RegionName { get; set; }
        [Required]
        [MaxLength(150)]
        public string CityName { get; set; }

        public ICollection<Car> Cars { get; set; }
            = new List<Car>();
    }
}
