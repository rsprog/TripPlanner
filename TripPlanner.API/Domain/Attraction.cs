namespace TripPlanner.API.Domain
{
    public enum AttractionLevel
    {
        Low,
        Medium,
        High
    }

    public enum AttractionType
    {
        Other = 0,        
        Landmark,
        Museum,
        Park,
        Street,
        Square,
        Neighborhood,
        Restaurant,
        ZooOrAquarium,
        PlaceOfWorship,
        ShoppingCenter,
    }

    public class Attraction
    {
        public int Id { get; set; }
        public AttractionLevel Level { get; set; } = AttractionLevel.Medium;
        public AttractionType Type { get; set; } = AttractionType.Landmark;
        public bool IsEntering { get; set; }
        public bool IsEating { get; set; }
        public string? OpeningHours { get; set; }
        public bool IsVisited { get; set; }
        public bool IsTicketed { get; set; }

        public int ActivityId { get; set; }
        public int? BookingId { get; set; }

        public virtual Activity? Activity { get; set; }
        public virtual Booking? Booking { get; set; }

    }
}
