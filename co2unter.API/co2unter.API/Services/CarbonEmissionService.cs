using co2unter.API.Interfaces;
using co2unter.API.Models;

namespace co2unter.API.Services
{
    public class CarbonEmissionService : ICarbonEmissionService
    {
        public CarbonEmissionService()
        {
            
        }

        public async Task<ActualCarbonEmissionResponse> GetActualAsync()
        {
            Random random = new Random();
            int min = 0;
            int max = 10_000;
            int carbonEmissionG = random.Next(min, max);

            return new ActualCarbonEmissionResponse()
            {
                DateTime = DateTime.Now,
                CarbonEmissionG = carbonEmissionG,
                CarbonEmissionKg = carbonEmissionG / 1_000
            };
        }
    }
}
