using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Domain;
using TripPlanner.API.Interface;

namespace TripPlanner.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransportController(ITripStore store) : ControllerBase
    {
        [HttpGet]
        public Transport? Get([FromRoute] int id) => store.Transports.Get(id);

        [HttpPost]
        public void Add(Transport transport)
        {
            store.Transports.Add(transport);
            store.Save();
        }

        [HttpPut]
        public void Update(Transport transport)
        {
            store.Transports.Update(transport);
            store.Save();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            store.Transports.Delete(id);
            store.Save();
        }
    }
}
