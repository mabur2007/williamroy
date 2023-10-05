using Tracker.domain.Entities;

namespace Tracker.application.Interfaces
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle>> GetAllAsync();

        Task AddAsync(Vehicle vehicle);


//        Task<Vehicle> GetByIdAsync(int id);
//        Task AddAsync(Vehicle vehicle);
    }
}
