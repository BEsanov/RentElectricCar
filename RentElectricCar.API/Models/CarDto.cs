using System;

namespace RentElectricCar.API.Models
{
    public class CarDto
    {
        public Guid CarId { get; set; }
        public string Brand { get; set; }
        public string ColorName { get; set; }
        public int MileAge { get; set; }
        public DateTimeOffset ProductionDate { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfSeats { get; set; }
        public Guid LocationId { get; set; }
    }
}
