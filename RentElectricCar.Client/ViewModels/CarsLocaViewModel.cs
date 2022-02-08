using RentElectricCar.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentElectricCar.Client.ViewModels
{
    public class CarsLocaViewModel
    {
        public IEnumerable<Location> Locationss { get; private set; }
          = new List<Location>();

        public CarsLocaViewModel(IEnumerable<Location> locations)
        {
            Locationss = locations;
        }
    }
}
