using co2unter.API.Interfaces;
using co2unter.API.Models;

namespace co2unter.API.Services;

public class ServiceEmissionsService : IServiceEmissionsService
{
    public List<ServiceEmissionModel> GetAllEmissions()
    {
        List<ServiceEmissionModel> emissionsData = new()
        {
            new ServiceEmissionModel
            {
                ServiceType = "gastronomy",
                TotalCO2EmissionsKg = 150.0,
                Year = 2024
            },
            new ServiceEmissionModel
            {
                ServiceType = "hospitality",
                TotalCO2EmissionsKg = 200.0,
                Year = 2024
            },
            new ServiceEmissionModel
            {
                ServiceType = "trade",
                TotalCO2EmissionsKg = 180.0,
                Year = 2024
            },
            new ServiceEmissionModel
            {
                ServiceType = "gastronomy",
                TotalCO2EmissionsKg = 140.0,
                Year = 2023
            },
            new ServiceEmissionModel
            {
                ServiceType = "hospitality",
                TotalCO2EmissionsKg = 210.0,
                Year = 2023
            },
            new ServiceEmissionModel
            {
                ServiceType = "trade",
                TotalCO2EmissionsKg = 175.0,
                Year = 2023
            }
        };

        return emissionsData;
    }

    public List<ServiceEmissionModel> GetEmissionsByYear(int year)
    {
        return GetAllEmissions().Where(e => e.Year == year).ToList();
    }

    public List<int> GetAvailableYears()
    {
        return GetAllEmissions().Select(e => e.Year).Distinct().ToList();
    }
}
