using Microsoft.AspNetCore.Mvc;
using Tracker.domain.Entities;
using Tracker.application.Interfaces;
using Tracker.persistence.Repositories;
using Tracker.application.Services;

namespace Tracker.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly VehicleService _vehicleService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
                                         VehicleService vehicleService)
        {
            _logger = logger;
            _vehicleService = vehicleService;
        }

        /*[HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }*/

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<Vehicle>> GetAsync()
        {
            Console.WriteLine("Test");
            //return (IEnumerable<Vehicle>)Ok(await _vehicleService.GetAllAsync());
            return await _vehicleService.GetAllVehiclesAsync();
        }
    }
}