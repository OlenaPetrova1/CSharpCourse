using Microsoft.AspNetCore.Mvc;

namespace CSharpCoursePart2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private static readonly List<Car> Cars = new List<Car> ()
        {
            new Car { Brand = "Audi", Model = "Q5", Price = 50000, Year = 2020},
            new Car { Brand = "Nissan", Model = "XTrail", Price = 35000, Year = 2022},
            new Car { Brand = "Mitsubishi", Model = "Lancer", Price = 30000, Year = 2021},
            new Car { Brand = "Tesla", Model = "S 2015", Price = 50000, Year = 2015}
        };

        private readonly ILogger<CarController> _logger;

        public CarController(ILogger<CarController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCar")]
        public IEnumerable<Car> Get()
        {
            return Cars;                
        }
    }
}