using co2unter.API.Infrastructure.Entities;
using co2unter.API.Interfaces;
using co2unter.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace co2unter.API.Controllers;

[ApiController]
[Route("api/emissions/service")]
public class ServiceEmissionsController : ControllerBase
{
    private readonly IServiceEmissionsRepository _serviceEmissionsRepository;

    public ServiceEmissionsController(IServiceEmissionsRepository serviceEmissionsService)
    {
        _serviceEmissionsRepository = serviceEmissionsService;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceEmissionModel>> GetAllServiceEmissions()
    {
        IEnumerable<ServiceEmission> serviceEmissions = await _serviceEmissionsRepository.GetAllAsync();
        List<ServiceEmissionModel> serviceEmissionModels = serviceEmissions.Select(x => x.Map()).ToList();
        return Ok(serviceEmissionModels);
    }

    [HttpGet("year/{year}")]
    public async Task<ActionResult<ServiceEmissionModel>> GetServiceEmissionsByYearAsync(int year)
    {
        List<ServiceEmission> serviceEmissions = await _serviceEmissionsRepository.GetByYearAsync(year);

        if (serviceEmissions.Count == 0)
            return NotFound($"No emissions data found for year: {year}");

        List<ServiceEmissionModel> serviceEmissionModels = serviceEmissions.Select(x => x.Map()).ToList();
        return Ok(serviceEmissionModels);
    }

    [HttpGet("years")]
    public async Task<ActionResult<int>> GetAvailableYearsAsync()
    {
        List<int> availableYears = await _serviceEmissionsRepository.GetAvailableYearsAsync();
        return Ok(availableYears);
    }
}
