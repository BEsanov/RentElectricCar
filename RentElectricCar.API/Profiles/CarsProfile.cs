using AutoMapper;

namespace RentElectricCar.API.Profiles
{
    public class CarsProfile:Profile
    {
        public CarsProfile()
        {
            CreateMap<Entities.Car, Models.CarDto>();
        }
    }
}
