namespace TripPlanner.API.Domain
{
    public enum AccomodationType
    {
        Other = 0,
        Hotel,
        Hostel,
        Apartment,
        AirBnb,
        Private,
    }

    public class Accomodation
    {
        public int Id { get; set; }
        public AccomodationType Type { get; set; } = AccomodationType.Hotel;
        public TimeOnly? MaxCheckInTime { get; set; }
        public TimeOnly? MaxCheckOutTime { get; set; }
        public bool IsPrepaid { get; set; }
        public string? RoomNumber { get; set; }

        public int CheckInId { get; set; }
        public int CheckOutId { get; set; }
        public int BookingId { get; set; }

        public virtual Activity? CheckIn { get; set; }
        public virtual Activity? CheckOut { get; set; }
        public virtual Booking? Booking { get; set; }

    }
}
