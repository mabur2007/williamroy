using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.domain.Entities;

namespace Tracker.application.Interfaces
{
    public interface IPatchRepository
    {
        Task<IEnumerable<Patch>> GetAllPatchesAsync();

    }
}
