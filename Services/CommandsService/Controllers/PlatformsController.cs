using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [ApiController]
    [Route("api/c/[controller]")]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {
            // Parameterless constructor
        }

        [HttpPost]
        public IActionResult TestInBoundConnection()
        {
            Console.WriteLine("Inbound POST # Command Service");
            return Ok("Inbound test of from Platforms Controller");
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            Console.WriteLine("Inbound GET # Command Service");
            return Ok("GET endpoint in PlatformsController is working.");
        }
    }
}
