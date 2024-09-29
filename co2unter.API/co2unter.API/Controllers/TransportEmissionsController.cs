using co2unter.API.Infrastructure.Entities;
using co2unter.API.Interfaces;
using co2unter.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace co2unter.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransportEmissionsController : ControllerBase
{
    private readonly ITransportEmissionsRepository _transportEmissionsRepository;

    public TransportEmissionsController(ITransportEmissionsRepository transportService)
    {
        _transportEmissionsRepository = transportService;
    }

    [HttpGet]
    public async Task<ActionResult<List<TransportEmissionModel>>> GetAllTransportEmissions()
    {
        IEnumerable<DbTransportEmission> transportEmissions = await _transportEmissionsRepository.GetAllAsync();
        List<TransportEmissionModel> transportEmissionModels = transportEmissions.Select(x => x.Map()).ToList();
        return Ok(transportEmissionModels);
    }

    [HttpGet("year/{year}")]
    public async Task<ActionResult<List<TransportEmissionModel>>> GetTransportEmissionsByYearAsync(int year)
    {
        IEnumerable<DbTransportEmission> transportEmissions = await _transportEmissionsRepository.GetByYearAsync(year);

        if (!transportEmissions.Any())
            return NotFound($"No emissions data found for year: {year}");

        List<TransportEmissionModel> transportEmissionModels = transportEmissions.Select(x => x.Map()).ToList();
        return Ok(transportEmissionModels);
    }

    [HttpGet("years")]
    public async Task<ActionResult<List<int>>> GetAvailableYears()
    {
        List<int> availableYears = await _transportEmissionsRepository.GetAvailableYearsAsync();
        return Ok(availableYears);
    }
}
