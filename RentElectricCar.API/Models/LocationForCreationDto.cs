using System.Collections.Generic;

namespace RentElectricCar.API.Models
{
    public class LocationForCreationDto
    {
        public string RegionName { get; set; }
        public string CityName { get; set; }

        public ICollection<CarsForCreationDto> Cars { get; set; }
            = new List<CarsForCreationDto>();
    }
}
