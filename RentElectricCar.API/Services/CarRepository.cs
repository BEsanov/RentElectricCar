using RentElectricCar.API.Contexts;
using RentElectricCar.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RentElectricCar.API.Services
{
    public class CarRepository : ICarRepository
    {
        private readonly RentACarDbContext _rentACarDbContext;

        public CarRepository(RentACarDbContext rentACarDbContext)
        {
            _rentACarDbContext = rentACarDbContext ??
                throw new ArgumentNullException(nameof(rentACarDbContext));
        }
        public IEnumerable<Car> GetCars()
        {
            var carsFromDb = _rentACarDbContext.CarsForRent.ToList();

            return carsFromDb;
        }

        public IEnumerable<Location> GetLocations()
        {
            var regionsAndCities = _rentACarDbContext.Locations.ToList();

            return regionsAndCities;
        }
        public Location GetLocation(Guid locationId)
        {
            var regionAndCity = _rentACarDbContext.Locations.FirstOrDefault(x => x.LocationId == locationId);

            return regionAndCity;
        }




        public IEnumerable<Car> GetCarsByLocation(Guid locationId)
        {
            //get location id
            //var carsInLocationFromRepo = _rentACarDbContext.Locations.FirstOrDefault(x=>x.LocationId==locationId);

            //if (carsInLocationFromRepo==null)
            //{
            //    GetLocations();
            //}
            return _rentACarDbContext.CarsForRent.Where(x => x.LocationId == locationId).OrderBy(c => c.MileAge).ToList();

            //verify if location exist
            //get cars according to location id;

            //var carsInlocation = _rentACarDbContext.Locations.FirstOrDefault(car => car.LocationId == locationId);

            //return carsInlocation;
        }


    }
}
