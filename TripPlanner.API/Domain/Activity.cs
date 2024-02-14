namespace TripPlanner.API.Domain
{
    public enum ActivityType
    {
        Other = 0,
        Visit,
        Depart,
        Arrive,
        CheckIn,
        CheckOut,
    }

    public class Activity
    {
        public int Id { get; set; }
        public ActivityType Type { get; set; }
        public required string Location { get; set; }
        public string? Address { get; set; }
        public DateTime Date { get; set; }
        public bool IsTimeExact { get; set; }
        public int Duration { get; set; }
        public string? TravelToInfo { get; set; }
        public string? Notes { get; set; }
        public int DestinationId { get; set; }

        public virtual Destination? Destination { get; set; }
    }
}
