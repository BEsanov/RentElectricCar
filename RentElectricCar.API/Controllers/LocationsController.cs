using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RentElectricCar.API.Entities;
using RentElectricCar.API.Models;
using RentElectricCar.API.Services;
using System;
using System.Collections.Generic;

namespace RentElectricCar.API.Controllers
{
    [ApiController]
    [Route("api/locations")]
    public class LocationsController : ControllerBase
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public LocationsController(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository ??
                throw new ArgumentNullException(nameof(carRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet]
        public ActionResult<IEnumerable<LocationDto>> GetLocations(string regionName,
            string searchQuery)
        {
            var carsFromRepo = _carRepository.GetLocations(regionName,searchQuery);

            return Ok(_mapper.Map<IEnumerable<LocationDto>>(carsFromRepo));
        }

        [HttpGet("{locationId}")]
        public IActionResult GetLocation(Guid locationId)
        {
            var locationFromRepo = _carRepository.GetLocation(locationId);

            if (locationFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<LocationDto>(locationFromRepo));
        }



    }
}
