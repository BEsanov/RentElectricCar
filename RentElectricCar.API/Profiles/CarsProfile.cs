using AutoMapper;
using RentElectricCar.Shared.Models;

namespace RentElectricCar.API.Profiles
{
    public class CarsProfile:Profile
    {
        public CarsProfile()
        {
            CreateMap<Entities.Car, CarDto>()
                .ForMember(
                dest => dest.Brand,
                opt => opt.MapFrom(src => src.CarBrandName));

            CreateMap<CarsForCreationDto, Entities.Car>();
        }
    }
}
