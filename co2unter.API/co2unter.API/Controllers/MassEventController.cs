using Microsoft.AspNetCore.Mvc;

namespace co2unter.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MassEventController : Controller
    {
        public MassEventController()
        {
            
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
