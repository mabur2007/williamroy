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
    public class PatchRepository : IPatchRepository
    {

        private readonly TrackerDbContext _context;

        public PatchRepository(TrackerDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<IEnumerable<Patch>> GetAllPatchesAsync()
        {
            //return await _context.Vehicle.ToListAsync();
            return await _context.Patch.ToListAsync();
            //.Include(x => x.Events).ToListAsync();
        }
    }
}
