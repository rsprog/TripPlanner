using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Domain;
using TripPlanner.API.Interface;

namespace TripPlanner.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController(ITripStore store) : ControllerBase
    {
        [HttpGet]
        public Booking? Get([FromRoute] int id) => store.Bookings.Get(id);

        [HttpPost]
        public void Add(Booking booking)
        {
            store.Bookings.Add(booking);
            store.Save();
        }

        [HttpPut]
        public void Update(Booking booking)
        {
            store.Bookings.Update(booking);
            store.Save();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            store.Bookings.Delete(id);
            store.Save();
        }
    }
}
