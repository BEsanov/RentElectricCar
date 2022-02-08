using System;

namespace RentElectricCar.API.Models
{
    public class LocationDto
    {
        public Guid LocationId { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
    }
}
