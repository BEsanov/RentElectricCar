using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentElectricCar.Web.Models.Api
{
    public class Location
    {
        public Guid LocationId { get; set; }
        public string RegionName { get; set; }
        public string CityName { get; set; }
    }
}
