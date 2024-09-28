using co2unter.API.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace co2unter.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OpenWeatherMapController : ControllerBase
{
    private static readonly HttpClient client = new();
    private const string BaseUrl = "http://api.openweathermap.org/data/2.5/air_pollution";
    private readonly string _apiKey;

    public OpenWeatherMapController(IOptions<OpenWeatherMapSettings> options)
    {
        _apiKey = options.Value.ApiKey;
    }

    [HttpGet]
    public async Task<string> GetAsync()
    {
        // Krakow's latitude and longitude
        string lat = "50.0647";
        string lon = "19.9450";

        string url = $"{BaseUrl}?lat={lat}&lon={lon}&appid={_apiKey}";

        HttpResponseMessage response = await client.GetAsync(url);

        return await response.Content.ReadAsStringAsync();
    }
}
