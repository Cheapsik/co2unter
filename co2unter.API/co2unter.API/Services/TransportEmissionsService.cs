using co2unter.API.Interfaces;
using co2unter.API.Models;

namespace co2unter.API.Services;

public class TransportEmissionsService : ITransportEmissionsService
{
    public List<TransportEmissionModel> GetAllEmissions()
    {
        List<TransportEmissionModel> emissionsData = new()
        {
            new TransportEmissionModel
            {
                TransportType = "car",
                TotalCO2EmissionsKg = 250.0,
                TotalDistanceKm = 1500.0,
                Year = 2024
            },
            new TransportEmissionModel
            {
                TransportType = "car",
                TotalCO2EmissionsKg = 220.0,
                TotalDistanceKm = 1400.0,
                Year = 2023
            },
            new TransportEmissionModel
            {
                TransportType = "public transport",
                TotalCO2EmissionsKg = 75.0,
                TotalDistanceKm = 1200.0,
                Year = 2024
            },
            new TransportEmissionModel
            {
                TransportType = "public transport",
                TotalCO2EmissionsKg = 80.0,
                TotalDistanceKm = 1300.0,
                Year = 2023
            },
            new TransportEmissionModel
            {
                TransportType = "bike",
                TotalCO2EmissionsKg = 0.0,
                TotalDistanceKm = 500.0,
                Year = 2024
            },
            new TransportEmissionModel
            {
                TransportType = "bike",
                TotalCO2EmissionsKg = 0.0,
                TotalDistanceKm = 400.0,
                Year = 2023
            },
            new TransportEmissionModel
            {
                TransportType = "walking",
                TotalCO2EmissionsKg = 0.0,
                TotalDistanceKm = 300.0,
                Year = 2024
            },
            new TransportEmissionModel
            {
                TransportType = "walking",
                TotalCO2EmissionsKg = 0.0,
                TotalDistanceKm = 250.0,
                Year = 2023
            }
        };

        return emissionsData;
    }

    public List<TransportEmissionModel> GetEmissionsByYear(int year)
    {
        return GetAllEmissions().Where(e => e.Year == year).ToList();
    }

    public List<int> GetAvailableYears()
    {
        return GetAllEmissions().Select(e => e.Year).Distinct().ToList();
    }
}
