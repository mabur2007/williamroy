using Microsoft.EntityFrameworkCore;
using Tracker.domain.Entities;

namespace Tracker.persistence
{
    public class TrackerDbContext : DbContext
    {
        public TrackerDbContext(DbContextOptions<TrackerDbContext> options) : base(options) { }

        public DbSet<Vehicle> Vehicle { get; set; }
    }
}
