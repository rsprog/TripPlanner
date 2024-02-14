using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Domain;
using TripPlanner.API.Interface;

namespace TripPlanner.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AttractionController(ITripStore store) : ControllerBase
    {
        [HttpGet]
        public Attraction? Get([FromRoute] int id) => store.Attractions.Get(id);

        [HttpPost]
        public void Add(Attraction attraction)
        {
            store.Attractions.Add(attraction);
            store.Save();
        }

        [HttpPut]
        public void Update(Attraction attraction)
        {
            store.Attractions.Update(attraction);
            store.Save();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            store.Attractions.Delete(id);
            store.Save();
        }
    }
}
