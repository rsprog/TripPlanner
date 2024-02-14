namespace TripPlanner.API.Domain
{
    public class Destination
    {
        public int Id { get; set; }
        public required string City { get; set; }
        public required string Country { get; set; }
        public Guid TripId { get; set; }

        public virtual Trip? Trip { get; set; }
        public virtual List<Activity>? Activities { get; set; }
    }
}
