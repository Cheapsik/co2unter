using co2unter.API.Interfaces;
using co2unter.API.Models;
using co2unter.API.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace co2unter.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarbonEmissionController : ControllerBase
{
    private static readonly HttpClient client = new();
    private const string ApiKey = "m5EjrP1XFrnk5a97CBbLYg";
    private const string BaseUrl = "https://www.carboninterface.com/api/v1/";

    private readonly ILogger<CarbonEmissionController> _logger;
    private readonly ICarbonEmissionService _carbonEmissionService;

    public CarbonEmissionController(ILogger<CarbonEmissionController> logger, ICarbonEmissionService carbonEmissionService)
    {
        _logger = logger;
        _carbonEmissionService = carbonEmissionService;
    }

    [HttpGet]
    public async Task<ActionResult<string>> GetAsync()
    {
        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", ApiKey);

        var requestBody = new
        {
            type = "fuel_combustion",
            fuel_source_type = "dfo",  // Must be a valid fuel type
            fuel_source_unit = "btu",       // Unit must be valid (like "l" for liters)
            fuel_source_value = 2       // Make sure this is a valid numeric value
        };

        var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

        HttpResponseMessage response = await client.PostAsync($"{BaseUrl}estimates", content);

        response.EnsureSuccessStatusCode();

        return Ok(await response.Content.ReadAsStringAsync());
    }

    [HttpGet("actual")]
    public async Task<ActionResult<ActualCarbonEmissionResponse>> GetActualAsync()
    {
        return Ok(await _carbonEmissionService.GetActualAsync());
    }
}
