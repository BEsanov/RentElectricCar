using System;

namespace RentElectricCar.API.Models
{
    public class CarsForCreationDto
    {
        public string Brand { get; set; }
        public string ColorName { get; set; }
        public int MileAge { get; set; }
        public DateTimeOffset ProductionDate { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfSeats { get; set; }
      
    }
}
