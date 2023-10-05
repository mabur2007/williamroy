using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.application.Interfaces;
using Tracker.domain.Entities;

namespace Tracker.persistence.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {

        private readonly TrackerDbContext _context;

        public VehicleRepository(TrackerDbContext dbContext) 
        {
            _context = dbContext;
        }

        public async Task<IEnumerable<Vehicle>> GetAllAsync()
        {
            //return await _context.Vehicle.ToListAsync();
            return await _context.Vehicle.Include(_ => _.Address).ToListAsync();
        }

        public async Task DeleteAsync(Vehicle vehicle)
        { 
            _context.Vehicle.Remove(vehicle);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Vehicle vehicle)
        {
            _context.Vehicle.Update(vehicle);
            await _context.SaveChangesAsync();
        }

        public async Task AddAsync(Vehicle vehicle)
        {
            _context.Vehicle.Add(vehicle);
            await _context.SaveChangesAsync();
        }

    }
}
