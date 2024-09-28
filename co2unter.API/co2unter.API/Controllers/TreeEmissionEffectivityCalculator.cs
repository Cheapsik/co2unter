using co2unter.API.Models.Enums;
using co2unter.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace co2unter.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TreeEmissionEffectivityCalculator : Controller
    {
        private readonly ITreeEmissionEffectivityCalculateService _treeCalculatorService;

        public TreeEmissionEffectivityCalculator(ITreeEmissionEffectivityCalculateService treeCalculatorService)
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
