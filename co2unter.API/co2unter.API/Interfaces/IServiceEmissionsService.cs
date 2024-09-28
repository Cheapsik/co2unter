using co2unter.API.Models;

namespace co2unter.API.Interfaces
{
    public interface IServiceEmissionsService
    {
        List<ServiceEmissionModel> GetAllEmissions();

        List<ServiceEmissionModel> GetEmissionsByYear(int year);

        List<int> GetAvailableYears();
    }
}
