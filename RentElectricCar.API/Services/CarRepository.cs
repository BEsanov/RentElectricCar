using RentElectricCar.API.Contexts;
using RentElectricCar.API.Entities;
using RentElectricCar.API.ResourceParameters;
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
        public IEnumerable<Location> GetLocations(LocationsResourceParameters locationsResourceParameters)
        {
            if (locationsResourceParameters == null)
            {
                throw new ArgumentNullException(nameof(locationsResourceParameters));
            }

            if (string.IsNullOrWhiteSpace(locationsResourceParameters.RegionName)
                && string.IsNullOrWhiteSpace(locationsResourceParameters.SearchQuery))
            {
                return GetLocations();
            }

            var collection = _rentACarDbContext.Locations as IQueryable<Location>;

            if (!string.IsNullOrWhiteSpace(locationsResourceParameters.RegionName))
            {
                var regionName = locationsResourceParameters.RegionName.Trim();
                collection = collection.Where(ct => ct.RegionName == regionName);
            }

            if (!string.IsNullOrWhiteSpace(locationsResourceParameters.SearchQuery))
            {
                var searchQuery = locationsResourceParameters.SearchQuery.Trim();

                collection = collection.Where(sq => sq.CityName.Contains(searchQuery) ||
                sq.RegionName.Contains(searchQuery));
            }

            return collection.ToList();
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

        public bool LocationExists(Guid locationId)
        {
            if (locationId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(locationId));
            }
            return _rentACarDbContext.Locations.Any(loc => loc.LocationId == locationId);
        }

        public IEnumerable<Car> GetCars(Guid locationId)
        {
            if (locationId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(locationId));
            }

            var carsFromRepo = _rentACarDbContext.CarsForRent.Where(car => car.LocationId == locationId)
                .ToList();

            return carsFromRepo;
        }

        public Car GetCarForLocation(Guid locationId, Guid carId)
        {
            if (locationId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(locationId));
            }
            if (carId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(carId));
            }

            var carFromDbForLocation = _rentACarDbContext.CarsForRent.Where(car => car.LocationId == locationId && car.CarId == carId)
                .FirstOrDefault();

            return carFromDbForLocation;
        }

        public void AddLocation(Location location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            //Generating new Guid for LocationId
            location.LocationId = Guid.NewGuid();

            //filling carId with new CarId
            foreach (var car in location.Cars)
            {
                car.CarId = Guid.NewGuid();
            }
            _rentACarDbContext.Locations.Add(location);

        }

        public bool Save()
        {
            var save = _rentACarDbContext.SaveChanges() >= 0;

            return save;
        }
    }
}
