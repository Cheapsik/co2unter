using Microsoft.AspNetCore.Mvc;

namespace co2unter.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OpenWeatherMapController : ControllerBase
    {
        private static readonly HttpClient client = new();
        private const string ApiKey = "3086d261b0afb19fa6b89c188476970f";
        private const string BaseUrl = "http://api.openweathermap.org/data/2.5/air_pollution";

        [HttpGet]
        public async Task<string> GetAsync()
        {
            // Kraków's latitude and longitude
            string lat = "50.0647";
            string lon = "19.9450";

            string url = $"{BaseUrl}?lat={lat}&lon={lon}&appid={ApiKey}";

            HttpResponseMessage response = await client.GetAsync(url);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
