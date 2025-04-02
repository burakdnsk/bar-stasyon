using barİstasyon.Domain.Entities;
using barİstasyon.Persistence.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace barİstasyon.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoffeeController : ControllerBase
    {
        private readonly MongoDbService _mongoDbService;

        public CoffeeController(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }

        [HttpGet]
        public ActionResult GetCoffees()
        {
            var collection = _mongoDbService.GetCollection<Coffee>("Coffees");
            var coffees = collection.Find(_ => true).ToList(); 
            return Ok(coffees);
        }

        
    }
}

