using RentElectricCar.Web.Models.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentElectricCar.Web.Services
{
    public interface ILocationListService
    {
        Task<IEnumerable<Location>> GetAll();
 
    }
}
