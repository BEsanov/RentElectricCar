using AutoMapper;

namespace RentElectricCar.API.Profiles
{
    public class CarsProfile:Profile
    {
        public CarsProfile()
        {
            CreateMap<Entities.Car, Models.CarDto>()
                .ForMember(
                dest => dest.Brand,
                opt => opt.MapFrom(src => src.CarBrandName));
        }
    }
}
