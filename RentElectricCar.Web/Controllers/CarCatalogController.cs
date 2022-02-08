using Microsoft.AspNetCore.Mvc;
using RentElectricCar.Web.Models.View;
using RentElectricCar.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentElectricCar.Web.Controllers
{
    public class CarCatalogController : Controller
    {
        private readonly ILocationListService _locationListService;

        public CarCatalogController(ILocationListService locationListService)
        {
            _locationListService = locationListService;
        }




        public async Task<IActionResult> Index(Guid categoryId)
        {
            var getLocations = _locationListService.GetCategories();
       

            return View(
                new LocationListModel
                {
                    Locations = getLocations.Result,
               }
            );
        }
    }
}
