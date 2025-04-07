using System.ComponentModel.DataAnnotations;

namespace cloudDevP1.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateOnly EventDate { get; set; }
        public string Description { get; set; }
        public int VenueId { get; set; }
        public Venue Venue { get; set; }
        public List<Booking> Bookings { get; set; } = new();
    }
}
