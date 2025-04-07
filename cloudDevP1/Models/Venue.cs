using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Logging;

namespace cloudDevP1.Models
{
    public class Venue
    {
        [Key]
        public int VenueId { get; set; }
        public string VenueName { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public string ImageUrl { get; set; }
        public List<Event> Events { get; set; } = new();
        public List<Booking> Bookings { get; set; } = new();
    }
}
