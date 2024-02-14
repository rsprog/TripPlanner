namespace TripPlanner.API.Domain
{
    public class Booking
    {
        public int Id { get; set; }
        public bool IsBooked { get; set; }
        public bool IsPaid { get; set; }
        public string? BookingReference { get; set; }
        public double Cost { get; set; }
    }
}
