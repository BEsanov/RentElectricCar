using RentElectricCar.Web.Models.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentElectricCar.Web.Models.View
{
    public class LocationListModel
    {
        public IEnumerable<Location> Locations { get; set; }
    }
}
