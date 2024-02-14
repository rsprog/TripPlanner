namespace TripPlanner.API.Domain
{
    public class Trip
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public virtual List<Destination>? Destinations { get; set; }
    }
}
