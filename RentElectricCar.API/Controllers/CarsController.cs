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
                return NotFound();
            }
            var carsFromRepo = _carRepository.GetCars(locationId);
            return Ok(_mapper.Map<IEnumerable<CarDto>>(carsFromRepo));
        }
        [HttpGet("{carId}", Name = "GetSingleCarForLocation")]
        public ActionResult<CarDto> GetSingleCarForLocation(Guid locationId, Guid carId)
        {
            //Check if location exists
            if (!_carRepository.LocationExists(locationId))
            {
                return NotFound();
            }

            var carFromRepoForLocation = _carRepository.GetCarForLocation(locationId, carId);

            return Ok(_mapper.Map<CarDto>(carFromRepoForLocation));
        }
        [HttpPost]
        public ActionResult<CarDto> CreateCarsForLocation(Guid locationId, CarsForCreationDto car)
        {
            if (!_carRepository.LocationExists(locationId))
            {
                return NotFound();
            }

            var carEntity = _mapper.Map<Entities.Car>(car);

            _carRepository.AddCar(locationId, carEntity);
            _carRepository.Save();

            var carToReturn = _mapper.Map<CarDto>(carEntity);

            return CreatedAtRoute("GetSingleCarForLocation", new { carId = carToReturn.CarId },
                carToReturn);
        }
    }
}
