using co2unter.API.Models;

namespace co2unter.API.Interfaces
{
    public interface ICarbonEmissionService
    {
        public Task<ActualCarbonEmissionResponse> GetActualAsync();
    }
}
