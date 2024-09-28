using co2unter.API.Interfaces;
using co2unter.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace co2unter.API.Controllers;

[ApiController]
[Route("api/emissions/service")]
public class ServiceEmissionsController : ControllerBase
{
    private readonly IServiceEmissionsService _serviceEmissionsService;

    public ServiceEmissionsController(IServiceEmissionsService serviceEmissionsService)
    {
        _serviceEmissionsService = serviceEmissionsService;
    }

    [HttpGet]
    public IActionResult GetAllServiceEmissions()
    {
        List<ServiceEmissionModel> emissionsData = _serviceEmissionsService.GetAllEmissions();
        return Ok(emissionsData);
    }

    [HttpGet("year/{year}")]
    public IActionResult GetServiceEmissionsByYear(int year)
    {
        List<ServiceEmissionModel> emissionsData = _serviceEmissionsService.GetEmissionsByYear(year);

        if (emissionsData.Count == 0)
            return NotFound($"No emissions data found for year: {year}");

        return Ok(emissionsData);
    }

    [HttpGet("years")]
    public IActionResult GetAvailableYears()
    {
        List<int> availableYears = _serviceEmissionsService.GetAvailableYears();
        return Ok(availableYears);
    }
}
