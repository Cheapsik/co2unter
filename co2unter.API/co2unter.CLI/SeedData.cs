using System.Xml.Linq;
using co2unter.API.Infrastructure.Entities;

namespace co2unter.CLI;

public static class SeedData
{
    public static List<DbServiceEmission> ServiceEmissions = new()
    {
        new DbServiceEmission
        {
            ServiceType = "gastronomy",
            TotalCO2EmissionsKg = 150.0,
            Year = 2024
        },
        new DbServiceEmission
        {
            ServiceType = "hospitality",
            TotalCO2EmissionsKg = 200.0,
            Year = 2024
        },
        new DbServiceEmission
        {
            ServiceType = "trade",
            TotalCO2EmissionsKg = 180.0,
            Year = 2024
        },
        new DbServiceEmission
        {
            ServiceType = "gastronomy",
            TotalCO2EmissionsKg = 140.0,
            Year = 2023
        },
        new DbServiceEmission
        {
            ServiceType = "hospitality",
            TotalCO2EmissionsKg = 210.0,
            Year = 2023
        },
        new DbServiceEmission
        {
            ServiceType = "trade",
            TotalCO2EmissionsKg = 175.0,
            Year = 2023
        }
    };

    public static List<DbTransportEmission> TransportEmissions = new()
    {
        new DbTransportEmission
        {
            TransportType = "car",
            TotalCO2EmissionsKg = 250.0,
            TotalDistanceKm = 1500.0,
            Year = 2024
        },
        new DbTransportEmission
        {
            TransportType = "car",
            TotalCO2EmissionsKg = 220.0,
            TotalDistanceKm = 1400.0,
            Year = 2023
        },
        new DbTransportEmission
        {
            TransportType = "public transport",
            TotalCO2EmissionsKg = 75.0,
            TotalDistanceKm = 1200.0,
            Year = 2024
        },
        new DbTransportEmission
        {
            TransportType = "public transport",
            TotalCO2EmissionsKg = 80.0,
            TotalDistanceKm = 1300.0,
            Year = 2023
        },
        new DbTransportEmission
        {
            TransportType = "bike",
            TotalCO2EmissionsKg = 0.0,
            TotalDistanceKm = 500.0,
            Year = 2024
        },
        new DbTransportEmission
        {
            TransportType = "bike",
            TotalCO2EmissionsKg = 0.0,
            TotalDistanceKm = 400.0,
            Year = 2023
        },
        new DbTransportEmission
        {
            TransportType = "walking",
            TotalCO2EmissionsKg = 0.0,
            TotalDistanceKm = 300.0,
            Year = 2024
        },
        new DbTransportEmission
        {
            TransportType = "walking",
            TotalCO2EmissionsKg = 0.0,
            TotalDistanceKm = 250.0,
            Year = 2023
        }
    };

    public static List<DbMassEvent> MassEvents = new()
    {
        new DbMassEvent() { Id = Guid.NewGuid(), EventDate = DateTime.Now, Name = "XD1", EmmissionT = 100, Place = "Tama" },
        new DbMassEvent() { Id = Guid.NewGuid(), EventDate = DateTime.Now.AddDays(-2), Name = "XD2", EmmissionT = 10, Place = "Tauron Arena" },
        new DbMassEvent() { Id = Guid.NewGuid(), EventDate = DateTime.Now.AddDays(-3), Name = "XD2_1", EmmissionT = 10, Place = "slumsy" },
        new DbMassEvent() { Id = Guid.NewGuid(), EventDate = DateTime.Now, Name = "XD1_1", EmmissionT = 242, Place = "Bulwary" },
        new DbMassEvent() { Id = Guid.NewGuid(), EventDate = DateTime.Now.AddYears(-1), Name = "XD3", EmmissionT = 20, Place = "Tama" },
        new DbMassEvent() { Id = Guid.NewGuid(), EventDate = DateTime.Now.AddDays(-4), Name = "XD2_2", EmmissionT = 10, Place = "Stadion" },
    };
}
