using AutoMapper;

namespace RentElectricCar.API.Profiles
{
    public class LocationsProfile: Profile
    {
        public LocationsProfile()
        {
            CreateMap<Entities.Location, Models.LocationDto>()
                .ForMember(
                dest => dest.Region,
                opt => opt.MapFrom(src => src.RegionName))
                .ForMember(
                dest =>dest.City,
                opt => opt.MapFrom(src => src.CityName));

            CreateMap<Models.LocationForCreationDto, Entities.Location>();
        }
    }
}
