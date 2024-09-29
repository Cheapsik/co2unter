using co2unter.API.Infrastructure.Entities;
using co2unter.API.Interfaces;
using co2unter.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace co2unter.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MassEventController : Controller
    {
        private readonly IMassEventRepository _massEventRepository;

        public MassEventController(IMassEventRepository massEventService)
        {
            _massEventRepository = massEventService;
        }

        [HttpGet("all")]
        public async Task<ActionResult<MassEventModel>> GetAllAsync()
        {
            IEnumerable<DbMassEvent> massEvents = await _massEventRepository.GetAllAsync();
            List<MassEventModel> massEventModels = massEvents.Select(x => x.Map()).ToList();
            return Ok(massEventModels);
        }

        [HttpGet("{massEventId}")]
        public async Task<ActionResult<MassEventModel>> GetByIdAsync(Guid massEventId)
        {
            DbMassEvent? massEvent = await _massEventRepository.GetMassEventByIdAsync(massEventId);
            if (massEvent is null)
                return NotFound();

            MassEventModel massEventModel = massEvent.Map();
            return Ok(massEventModel);
        }
    }
}
