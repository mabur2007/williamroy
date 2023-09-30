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
            return await _context.Vehicle.ToListAsync();
        }
    }
}
