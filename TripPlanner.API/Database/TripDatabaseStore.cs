using TripPlanner.API.Domain;
using TripPlanner.API.Interface;

namespace TripPlanner.API.Database
{
    /// <summary>
    /// Entity framework specific implementation of the generic trip manager
    /// </summary>
    /// <param name="context"></param>
    public class TripDatabaseStore(TripDatabaseContext context) : ITripStore
    {
        public IRepository<Accomodation> Accomodations { get; } = new DatabaseRepository<Accomodation>(context);

        public IRepository<Activity> Activities { get; } = new DatabaseRepository<Activity>(context);

        public IRepository<Attraction> Attractions { get; } = new DatabaseRepository<Attraction>(context);

        public IRepository<Booking> Bookings { get; } = new DatabaseRepository<Booking>(context);

        public IRepository<Destination> Destinations { get; } = new DatabaseRepository<Destination>(context);

        public IRepository<Transport> Transports { get; } = new DatabaseRepository<Transport>(context);

        public IRepository<Trip> Trips { get; } = new DatabaseRepository<Trip>(context);

        public void Save() => context.SaveChanges();
    }
}
