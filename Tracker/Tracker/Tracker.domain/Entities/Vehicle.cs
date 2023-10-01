using Tracker.domain.Common;

namespace Tracker.domain.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string? RegNo { get; set; }
        public string? Color { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
    }
}