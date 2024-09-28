using co2unter.API.Interfaces;
using co2unter.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace co2unter.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MassEventController : Controller
    {
        private readonly IMassEventService _massEventService;

        public MassEventController(IMassEventService massEventService)
        {
            _massEventService = massEventService;
        }

        [HttpGet("all")]
        public async Task<ActionResult<MassEvent>> GetAllAsync()
        {
            return Ok(await _massEventService.GetAllMassEvents());
        }

        [HttpGet("{massEventId}")]
        public async Task<ActionResult<MassEvent>> GetByIdAsync(Guid massEventId)
        {
            MassEvent? massEvent = await _massEventService.GetMassEventByIdAsync(massEventId);
            if (massEvent is null)
                return NotFound();

            return Ok(massEvent);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> PostAsync([FromBody] MassEvent massEvent)
        {
            return Created("/", await _massEventService.AddMassEventAsync(massEvent));
        }
    }
}
