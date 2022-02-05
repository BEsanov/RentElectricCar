using RentElectricCar.API.Entities;
using System;
using System.Collections.Generic;

namespace RentElectricCar.API.Services
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();

        IEnumerable<Location> GetLocations();
        Location GetLocation(Guid locationId);

       IEnumerable<Car> GetCarsByLocation(Guid locationId);

        bool LocationExists(Guid locationId);

        IEnumerable<Car> GetCars(Guid locationId);

        Car GetCarForLocation(Guid locationId, Guid carId);

    }
}
