using Microsoft.AspNetCore.Mvc;
using Tracker.domain.Entities;
using Tracker.application.Interfaces;
using Tracker.persistence.Repositories;
using Tracker.application.Services;

namespace Tracker.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatchController : ControllerBase
    {
        private readonly PatchService _patchService;

        public PatchController(PatchService patchService)
        {
            _patchService = patchService;
        }


        [HttpGet(Name = "GetPatches")]
        public async Task<IEnumerable<Patch>> GetPatchesAsync()
        {
            return await _patchService.GetAllPatchesAsync();
        }
    }
}
