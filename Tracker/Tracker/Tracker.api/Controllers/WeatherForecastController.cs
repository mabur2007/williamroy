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

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly VehicleService _vehicleService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
                                         VehicleService vehicleService)
        {
            _logger = logger;
            _vehicleService = vehicleService;
        }


        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<Vehicle>> GetAsync()
        {
            Console.WriteLine("Test");
            //return (IEnumerable<Vehicle>)Ok(await _vehicleService.GetAllAsync());
            return await _vehicleService.GetAllVehiclesAsync();
        }
    }
}