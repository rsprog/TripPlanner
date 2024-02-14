using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Domain;
using TripPlanner.API.Interface;

namespace TripPlanner.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DestinationController(ITripStore store) : ControllerBase
    {
        [HttpGet]
        public Destination? Get([FromRoute] int id) => store.Destinations.Get(id);

        [HttpPost]
        public void Add(Destination destination)
        {
            store.Destinations.Add(destination);
            store.Save();
        }

        [HttpPut]
        public void Update(Destination destination)
        {
            store.Destinations.Update(destination);
            store.Save();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            store.Destinations.Delete(id);
            store.Save();
        }
    }
}
