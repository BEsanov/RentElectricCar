using System;

namespace RentElectricCar.Shared.Models
{
    public class LocationDto
    {
        public Guid LocationId { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
    }
}
