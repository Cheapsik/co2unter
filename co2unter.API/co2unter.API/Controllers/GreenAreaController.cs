using co2unter.API.Interfaces;
using co2unter.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace co2unter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreenAreaController : ControllerBase
    {
        private readonly IGreenAreaRepository _greenAreaRepository;

        public GreenAreaController(IGreenAreaRepository greenAreaRepository)
        {
            _greenAreaRepository = greenAreaRepository;
        }

        [HttpGet]
        public async Task<ActionResult<GreenArea>> GetAsync()
        {
            return Ok(await _greenAreaRepository.GetAllAsync());
        }
    }
}
