using Tracker.domain.Entities;

namespace Tracker.application.Interfaces
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle>> GetAllAsync();
//        Task<Vehicle> GetByIdAsync(int id);
//        Task AddAsync(Vehicle vehicle);
    }
}
