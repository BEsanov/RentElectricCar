using Microsoft.AspNetCore.Mvc;
using RentElectricCar.API.Contexts;
using RentElectricCar.API.Entities;
using RentElectricCar.API.Services;
using System;

namespace RentElectricCar.API.Controllers
{
    [ApiController]
    [Route("api/locations/{locationId}/cars")]
    public class CarsController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public CarsController(ICarRepository carRepository)
        {
            _carRepository = carRepository ??
                throw new ArgumentNullException(nameof(carRepository));
        }
        [HttpGet]
        public IActionResult GetCars()
        {
            var carsFromRepo = _carRepository.GetCars();
            return Ok(carsFromRepo);
        }

        //[HttpGet]
        //public ActionResult<Location> GetCarsInLocation(Guid locationId)
        //{
        //    var carsFromRepo = _carRepository.GetCarsByLocation(locationId);

        //    return Ok(carsFromRepo);

        //}
    }
}
