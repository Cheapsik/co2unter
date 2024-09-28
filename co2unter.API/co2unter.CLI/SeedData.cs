using co2unter.API.Infrastructure.Entities;

namespace co2unter.CLI;

public static class SeedData
{
    public static List<ServiceEmission> ServiceEmissions = new()
    {
        new ServiceEmission
        {
            ServiceType = "gastronomy",
            TotalCO2EmissionsKg = 150.0,
            Year = 2024
        },
        new ServiceEmission
        {
            ServiceType = "hospitality",
            TotalCO2EmissionsKg = 200.0,
            Year = 2024
        },
        new ServiceEmission
        {
            ServiceType = "trade",
            TotalCO2EmissionsKg = 180.0,
            Year = 2024
        },
        new ServiceEmission
        {
            ServiceType = "gastronomy",
            TotalCO2EmissionsKg = 140.0,
            Year = 2023
        },
        new ServiceEmission
        {
            ServiceType = "hospitality",
            TotalCO2EmissionsKg = 210.0,
            Year = 2023
        },
        new ServiceEmission
        {
            ServiceType = "trade",
            TotalCO2EmissionsKg = 175.0,
            Year = 2023
        }
    };

    public static List<TransportEmission> TransportEmissions = new()
    {
        new TransportEmission
        {
            TransportType = "car",
            TotalCO2EmissionsKg = 250.0,
            TotalDistanceKm = 1500.0,
            Year = 2024
        },
        new TransportEmission
        {
            TransportType = "car",
            TotalCO2EmissionsKg = 220.0,
            TotalDistanceKm = 1400.0,
            Year = 2023
        },
        new TransportEmission
        {
            TransportType = "public transport",
            TotalCO2EmissionsKg = 75.0,
            TotalDistanceKm = 1200.0,
            Year = 2024
        },
        new TransportEmission
        {
            TransportType = "public transport",
            TotalCO2EmissionsKg = 80.0,
            TotalDistanceKm = 1300.0,
            Year = 2023
        },
        new TransportEmission
        {
            TransportType = "bike",
            TotalCO2EmissionsKg = 0.0,
            TotalDistanceKm = 500.0,
            Year = 2024
        },
        new TransportEmission
        {
            TransportType = "bike",
            TotalCO2EmissionsKg = 0.0,
            TotalDistanceKm = 400.0,
            Year = 2023
        },
        new TransportEmission
        {
            TransportType = "walking",
            TotalCO2EmissionsKg = 0.0,
            TotalDistanceKm = 300.0,
            Year = 2024
        },
        new TransportEmission
        {
            TransportType = "walking",
            TotalCO2EmissionsKg = 0.0,
            TotalDistanceKm = 250.0,
            Year = 2023
        }
    };
}
