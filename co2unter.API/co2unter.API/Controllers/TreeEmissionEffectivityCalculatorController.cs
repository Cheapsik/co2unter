using co2unter.API.Interfaces;
using co2unter.API.Models.Enums;
using Microsoft.AspNetCore.Mvc;

namespace co2unter.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TreeEmissionEffectivityCalculatorController : ControllerBase
    {
        private readonly ITreeEmissionEffectivityCalculateService _treeCalculatorService;

        public TreeEmissionEffectivityCalculatorController(ITreeEmissionEffectivityCalculateService treeCalculatorService)
        {
            _treeCalculatorService = treeCalculatorService;
        }

        [HttpGet("Calculate/Time/{treeAge}")]
        public async Task<IActionResult> GetAsync(TreeAgeEnum treeAge, [FromQuery] int co2weight)
        {
            return Ok(await _treeCalculatorService.CalculateTimeByWeight(treeAge, co2weight));
        }

        [HttpGet("Calculate/Co2Emission/{treeAge}")]
        public async Task<IActionResult> GetAsync(TreeAgeEnum treeAge, [FromQuery] DateTimeOffset dateFrom, [FromQuery] DateTimeOffset dateTo)
        {
            return Ok(await _treeCalculatorService.CalculateCo2EmissionByParoid(treeAge, dateFrom, dateTo));
        }
    }
}
