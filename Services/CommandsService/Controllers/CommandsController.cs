using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllCommands()
        {
            // Placeholder: return a simple message
            return Ok("Commands endpoint is working.");
        }
    }
}
