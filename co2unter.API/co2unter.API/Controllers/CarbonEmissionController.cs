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

    public CarbonEmissionController(ILogger<CarbonEmissionController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<string> GetAsync()
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

        return await response.Content.ReadAsStringAsync();

    }
}
