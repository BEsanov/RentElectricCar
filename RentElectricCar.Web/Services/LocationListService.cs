using RentElectricCar.Web.Extensions;
using RentElectricCar.Web.Models.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RentElectricCar.Web.Services
{
    public class LocationListService
    {
        private readonly HttpClient client;

        public LocationListService(HttpClient client)
        {
            this.client = client;
        }
        public async Task<IEnumerable<Location>> GetAll()
        {
            var response = await client.GetAsync("/api/locations");
            return await response.ReadContentAs<List<Location>>();
        }
    }
}
