using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.domain.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string? Addresss1 { get; set; }
        public string? Addresss2 { get; set; }
        public string? Addresss3 { get; set; }
        public string? PostCode { get; set; }
    }
}
