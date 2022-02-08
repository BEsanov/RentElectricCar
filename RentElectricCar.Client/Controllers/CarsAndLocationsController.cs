using Microsoft.AspNetCore.Mvc;
using RentElectricCar.API.Entities;
using RentElectricCar.Client.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace RentElectricCar.Client.Controllers
{
    public class CarsAndLocationsController:Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CarsAndLocationsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task Index()
        {
            var httpClient = _httpClientFactory.CreateClient("APIClient");

            var request = new HttpRequestMessage(
                HttpMethod.Get,
                "/api/locations/");

            var response = await httpClient.SendAsync(
                request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            using (var responseStream = await response.Content.ReadAsStreamAsync())
            {
                return View(new CarsLocaViewModel(
                    await JsonSerializer.DeserializeAsync<List<Location>>(responseStream)));
            }
        }

    }
}
