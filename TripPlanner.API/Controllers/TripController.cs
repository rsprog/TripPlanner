using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Domain;
using TripPlanner.API.Interface;

namespace TripPlanner.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TripController(ITripStore store) : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Trip> GetTrips() => store.Trips.GetAll();

        [HttpGet]
        [Route("{id}")]
        public Trip? Get([FromRoute] Guid id) => store.Trips.Get(id);

        [HttpPost]
        public void Add(Trip trip)
        {
            store.Trips.Add(trip);
            store.Save();
        }

        [HttpPut]
        public void Update(Trip trip)
        {
            store.Trips.Update(trip);
            store.Save();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            store.Trips.Delete(id);
            store.Save();
        }
    }
}
