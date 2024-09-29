using co2unter.API.Infrastructure.Entities;
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
            IEnumerable<DbGreenArea> greenAreas = await _greenAreaRepository.GetAllAsync();
            List<GreenArea> greenAreaModels = greenAreas.Select(x => x.Map()).ToList();
            return Ok(greenAreaModels);
        }
    }
}
