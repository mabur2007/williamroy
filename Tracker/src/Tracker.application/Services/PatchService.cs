using Tracker.application.Interfaces;
using Tracker.domain.Entities;

namespace Tracker.application.Services
{
    public class PatchService : IPatchRepository
    {
        private readonly IPatchRepository _repo;

        public PatchService(IPatchRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Patch>> GetAllPatchesAsync()
        {
            return (IEnumerable<Patch>)await _repo.GetAllPatchesAsync();
        }
    }
}
