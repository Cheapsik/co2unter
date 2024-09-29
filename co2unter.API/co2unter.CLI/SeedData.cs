using co2unter.API.Infrastructure.Entities;

namespace co2unter.CLI;

public static class SeedData
{
    public static List<DbServiceEmission> ServiceEmissions = new()
    {
        new DbServiceEmission { ServiceType = "gastronomy", TotalCO2EmissionsKg = 15000, Year = 2023 },
        new DbServiceEmission { ServiceType = "gastronomy", TotalCO2EmissionsKg = 16000, Year = 2024 },
        new DbServiceEmission { ServiceType = "hospitality", TotalCO2EmissionsKg = 10000, Year = 2023 },
        new DbServiceEmission { ServiceType = "hospitality", TotalCO2EmissionsKg = 11000, Year = 2024 },
        new DbServiceEmission { ServiceType = "trade", TotalCO2EmissionsKg = 8000, Year = 2023 },
        new DbServiceEmission { ServiceType = "trade", TotalCO2EmissionsKg = 8500, Year = 2024 },
        new DbServiceEmission { ServiceType = "health services", TotalCO2EmissionsKg = 5000, Year = 2023 },
        new DbServiceEmission { ServiceType = "health services", TotalCO2EmissionsKg = 5200, Year = 2024 },
    };

    public static List<DbTransportEmission> TransportEmissions = new()
    {
        new DbTransportEmission { TransportType = "car", TotalCO2EmissionsKg = 12000, TotalDistanceKm = 300, Year = 2023 },
        new DbTransportEmission { TransportType = "car", TotalCO2EmissionsKg = 12500, TotalDistanceKm = 320, Year = 2024 },
        new DbTransportEmission { TransportType = "public transport", TotalCO2EmissionsKg = 7000, TotalDistanceKm = 500, Year = 2023 },
        new DbTransportEmission { TransportType = "public transport", TotalCO2EmissionsKg = 7200, TotalDistanceKm = 520, Year = 2024 },
        new DbTransportEmission { TransportType = "bike", TotalCO2EmissionsKg = 500, TotalDistanceKm = 100, Year = 2023 },
        new DbTransportEmission { TransportType = "bike", TotalCO2EmissionsKg = 550, TotalDistanceKm = 110, Year = 2024 },
        new DbTransportEmission { TransportType = "walking", TotalCO2EmissionsKg = 100, TotalDistanceKm = 50, Year = 2023 },
        new DbTransportEmission { TransportType = "walking", TotalCO2EmissionsKg = 120, TotalDistanceKm = 60, Year = 2024 },
    };

    public static List<DbMassEvent> MassEvents = new()
    {
        new DbMassEvent { Id = Guid.NewGuid(), Name = "Kraków Music Festival", Place = "Stadion Miejski", EventDate = new DateTimeOffset(new DateTime(2023, 8, 12)), EmmissionT = 5 },
        new DbMassEvent { Id = Guid.NewGuid(), Name = "Kraków Music Festival", Place = "Stadion Miejski", EventDate = new DateTimeOffset(new DateTime(2024, 8, 10)), EmmissionT = 5 },
        new DbMassEvent { Id = Guid.NewGuid(), Name = "Kraków Christmas Market", Place = "Rynek Główny", EventDate = new DateTimeOffset(new DateTime(2023, 12, 1)), EmmissionT = 3 },
        new DbMassEvent { Id = Guid.NewGuid(), Name = "Kraków Christmas Market", Place = "Rynek Główny", EventDate = new DateTimeOffset(new DateTime(2024, 12, 1)), EmmissionT = 3 },
        new DbMassEvent { Id = Guid.NewGuid(), Name = "Kraków Food Festival", Place = "Park Jordana", EventDate = new DateTimeOffset(new DateTime(2023, 6, 20)), EmmissionT = 2 },
        new DbMassEvent { Id = Guid.NewGuid(), Name = "Kraków Food Festival", Place = "Park Jordana", EventDate = new DateTimeOffset(new DateTime(2024, 6, 15)), EmmissionT = 2 },
        new DbMassEvent { Id = Guid.NewGuid(), Name = "Kraków Film Festival", Place = "Centrum Kongresowe", EventDate = new DateTimeOffset(new DateTime(2023, 11, 5)), EmmissionT = 4 },
        new DbMassEvent { Id = Guid.NewGuid(), Name = "Kraków Film Festival", Place = "Centrum Kongresowe", EventDate = new DateTimeOffset(new DateTime(2024, 11, 3)), EmmissionT = 5 }, 
    };
}
