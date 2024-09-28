using co2unter.API.Models;

namespace co2unter.API.Interfaces;

public interface ITransportEmissionsService
{
    List<TransportEmissionModel> GetAllEmissions();

    List<TransportEmissionModel> GetEmissionsByYear(int year);

    List<int> GetAvailableYears();
}