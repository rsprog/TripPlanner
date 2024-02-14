using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Domain;
using TripPlanner.API.Interface;

namespace TripPlanner.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccomodationController(ITripStore store) : ControllerBase
    {
        [HttpGet]
        public Accomodation? Get([FromRoute] int id) => store.Accomodations.Get(id);

        [HttpPost]
        public void Add(Accomodation accomodation)
        {
            store.Accomodations.Add(accomodation);
            store.Save();
        }

        [HttpPut]
        public void Update(Accomodation accomodation)
        {
            store.Accomodations.Update(accomodation);
            store.Save();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            store.Accomodations.Delete(id);
            store.Save();
        }
    }
}
