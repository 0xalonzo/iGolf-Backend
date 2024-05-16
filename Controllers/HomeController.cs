using Microsoft.AspNetCore.Mvc;

namespace IgolfBackend.Controllers
{
    [Route("api")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to the iGolf Backend API");
        }
    }
}
