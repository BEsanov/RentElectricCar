using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RentElectricCar.API.Entities;
using RentElectricCar.API.ResourceParameters;
using RentElectricCar.API.Services;
using RentElectricCar.Shared.Models;
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
        public ActionResult<IEnumerable<LocationDto>> GetLocations([FromQuery] LocationsResourceParameters locationsResourceParameters)
        {
            var carsFromRepo = _carRepository.GetLocations(locationsResourceParameters);

            return Ok(_mapper.Map<IEnumerable<LocationDto>>(carsFromRepo));
        }

        [HttpGet("{locationId}", Name = "GetLocation")]
        public IActionResult GetLocation(Guid locationId)
        {
            var locationFromRepo = _carRepository.GetLocation(locationId);

            if (locationFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<LocationDto>(locationFromRepo));
        }
        [HttpPost]
        public ActionResult<LocationDto> CreateLocation(LocationForCreationDto location)
        {
            var newLocation = _mapper.Map<Entities.Location>(location);

            _carRepository.AddLocation(newLocation);
            _carRepository.Save();

            var locationToReturn = _mapper.Map<LocationDto>(newLocation);

            return CreatedAtRoute("GetLocation", new { locationId=newLocation.LocationId },
                locationToReturn);

        }

    }
}
