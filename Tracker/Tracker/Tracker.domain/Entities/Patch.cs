using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.domain.Entities
{
    public class Patch
    {
        public int PatchId { get; set; }
        public string? PatchCode { get; set; }
        //public List<Address> Addresses { get; set; }
    }
}
