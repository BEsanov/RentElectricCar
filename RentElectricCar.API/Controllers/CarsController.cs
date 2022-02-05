using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RentElectricCar.API.Contexts;
using RentElectricCar.API.Entities;
using RentElectricCar.API.Models;
using RentElectricCar.API.Services;
using System;
using System.Collections.Generic;

namespace RentElectricCar.API.Controllers
{
    [ApiController]
    [Route("api/locations/{locationId}/cars")]
    public class CarsController : ControllerBase
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarsController(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository ??
                throw new ArgumentNullException(nameof(carRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public ActionResult<IEnumerable<CarDto>> GetCarsForLocation(Guid locationId)
        {
            if (!_carRepository.LocationExists(locationId))
            {
                NotFound();
            }
            var carsFromRepo = _carRepository.GetCars(locationId);
            return Ok(_mapper.Map<IEnumerable<CarDto>>(carsFromRepo));
        }

    }
}
