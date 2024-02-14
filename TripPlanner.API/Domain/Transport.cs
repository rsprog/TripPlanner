namespace TripPlanner.API.Domain
{
    public enum TransportationMode
    {
        Other,
        Airplane,
        Train,
        Bus,
        Taxi,
        Boat,
        Bike,
        Walk
    }

    public class Transport
    {
        public int Id { get; set; }
        public TransportationMode TransportationMode { get; set; }
        public string? RouteNumber { get; set; }
        public string? SeatNumber { get; set; }
        public int TransitTime { get; set; }

        public int DepartureId { get; set; }
        public int ArrivalId { get; set; }
        public int BookingId { get; set; }

        public virtual Activity? Departure { get; set; }
        public virtual Activity? Arrival { get; set; }
        public virtual Booking? Booking { get; set; }

    }
}
