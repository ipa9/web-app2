using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomGenerator : ControllerBase
    {
        private readonly RandomGeneratorService _randomGeneratorService;
        private readonly RandomGeneratorService randomGeneratorService2;

        public RandomGenerator(RandomGeneratorService randomGeneratorService, RandomGeneratorService randomGeneratorService2)
        {
            _randomGeneratorService = randomGeneratorService;
            this.randomGeneratorService2 = randomGeneratorService2;
        }
        [HttpGet]
        public string Get()
        {
            return _randomGeneratorService.RandomString + "     " + randomGeneratorService2.RandomString;
        }
    }
}
