using Microsoft.AspNetCore.Mvc;
using RentElectricCar.API.Entities;
using RentElectricCar.API.Services;
using System;

namespace RentElectricCar.API.Controllers
{
    [ApiController]
    [Route("api/locations")]
    public class LocationsController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public LocationsController(ICarRepository carRepository)
        {
            _carRepository = carRepository ??
                throw new ArgumentNullException(nameof(carRepository));
        }
        [HttpGet]
        public IActionResult GetLocations()
        {
            var carsFromRepo = _carRepository.GetLocations();
            return Ok(carsFromRepo);
        }
        
        [HttpGet("{locationId}")]
        public IActionResult GetLocation(Guid locationId)
        {
            var locationFromRepo = _carRepository.GetLocation(locationId);

            if (locationFromRepo==null)
            {
                return NotFound();
            }

            return Ok(locationFromRepo);
        }


    }
}
