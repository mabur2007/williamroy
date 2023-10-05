using Microsoft.AspNetCore.Mvc;
using Tracker.domain.Entities;
using Tracker.application.Interfaces;
using Tracker.persistence.Repositories;
using Tracker.application.Services;

namespace Tracker.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {

        private readonly ILogger<VehicleController> _logger;
        private readonly VehicleService _vehicleService;

        public VehicleController(ILogger<VehicleController> logger,
                                         VehicleService vehicleService)
        {
            _logger = logger;
            _vehicleService = vehicleService;
        }


        [HttpGet(Name = "GetVehicles")]
        public async Task<IEnumerable<Vehicle>> GetAsync()
        {
            Console.WriteLine("Test");
            //return (IEnumerable<Vehicle>)Ok(await _vehicleService.GetAllAsync());
            return await _vehicleService.GetAllVehiclesAsync();
        }

        [HttpPost(Name = "GetVehicles")]
        public async Task<bool> PostAsync(Vehicle vehicle)
        {
            Console.WriteLine("Test");
            //return (IEnumerable<Vehicle>)Ok(await _vehicleService.InsertAsync());
            return await _vehicleService.InsertVehicleAsync(vehicle);
        }
    }
}