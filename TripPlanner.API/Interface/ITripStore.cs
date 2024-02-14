using TripPlanner.API.Domain;

namespace TripPlanner.API.Interface
{
    /// <summary>
    /// Provies access to CRUB operations for all entities in the domain
    /// </summary>
    public interface ITripStore
    {
        IRepository<Accomodation> Accomodations { get; }
        IRepository<Activity> Activities { get; }
        IRepository<Attraction> Attractions { get; }
        IRepository<Booking> Bookings { get; }
        IRepository<Destination> Destinations { get; }
        IRepository<Transport> Transports { get; }
        IRepository<Trip> Trips { get; }

        /// <summary>
        /// Saves changes
        /// </summary>
        void Save();
    }
}
