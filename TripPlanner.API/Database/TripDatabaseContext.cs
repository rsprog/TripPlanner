using Microsoft.EntityFrameworkCore;
using TripPlanner.API.Domain;

namespace TripPlanner.API.Database
{
    /// <summary>
    /// Entity framework context for trip entities
    /// </summary>
    public class TripDatabaseContext : DbContext
    {
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<Accomodation> Accomodations { get; set; }
        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public TripDatabaseContext() { }
        public TripDatabaseContext(DbContextOptions<TripDatabaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trip>().HasKey(x => x.Id);
            modelBuilder.Entity<Destination>().HasKey(x => x.Id);
            modelBuilder.Entity<Activity>().HasKey(x => x.Id);
            modelBuilder.Entity<Transport>().HasKey(x => x.Id);
            modelBuilder.Entity<Attraction>().HasKey(x => x.Id);
            modelBuilder.Entity<Booking>().HasKey(x => x.Id);

            modelBuilder.Entity<Destination>()
                .HasOne(s => s.Trip)
                .WithMany(s => s.Destinations)
                .HasForeignKey(s => s.TripId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Activity>()
                .HasOne(s => s.Destination)
                .WithMany(s => s.Activities)
                .HasForeignKey(s => s.DestinationId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Transport>()
                .HasOne(s => s.Departure)
                .WithMany()
                .HasForeignKey(s => s.DepartureId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Transport>()
                .HasOne(s => s.Arrival)
                .WithMany()
                .HasForeignKey(s => s.ArrivalId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Transport>()
                .HasOne(s => s.Booking)
                .WithMany()
                .HasForeignKey(s => s.BookingId);

            modelBuilder.Entity<Attraction>()
                .HasOne(s => s.Activity)
                .WithMany()
                .HasForeignKey(s => s.ActivityId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Attraction>()
                .HasOne(s => s.Booking)
                .WithMany()
                .HasForeignKey(s => s.BookingId);

            modelBuilder.Entity<Accomodation>()
                .HasOne(s => s.CheckIn)
                .WithMany()
                .HasForeignKey(s => s.CheckInId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Accomodation>()
                .HasOne(s => s.CheckOut)
                .WithMany()
                .HasForeignKey(s => s.CheckOutId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Accomodation>()
                .HasOne(s => s.Booking)
                .WithMany()
                .HasForeignKey(s => s.BookingId);
        }
    }
}
