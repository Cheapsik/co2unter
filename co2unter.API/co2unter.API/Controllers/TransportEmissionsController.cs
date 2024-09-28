using co2unter.API.Interfaces;
using co2unter.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace co2unter.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransportEmissionsController : ControllerBase
{
    private readonly ITransportEmissionsService _transportService;

    public TransportEmissionsController(ITransportEmissionsService transportService)
    {
        _transportService = transportService;
    }

    [HttpGet]
    public IActionResult GetAllTransportEmissions()
    {
        List<TransportEmissionModel> emissionsData = _transportService.GetAllEmissions();
        return Ok(emissionsData);
    }

    [HttpGet("year/{year}")]
    public IActionResult GetTransportEmissionsByYear(int year)
    {
        List<TransportEmissionModel> emissionsData = _transportService.GetEmissionsByYear(year);

        if (!emissionsData.Any())
            return NotFound($"No emissions data found for year: {year}");

        return Ok(emissionsData);
    }

    [HttpGet("years")]
    public IActionResult GetAvailableYears()
    {
        List<int> availableYears = _transportService.GetAvailableYears();
        return Ok(availableYears);
    }
}
