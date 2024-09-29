using co2unter.API.Infrastructure.Entities;
using co2unter.API.Models;

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
        new DbMassEvent { Id = Guid.NewGuid(), Name = "Kraków Music Festival", Place = "Stadion Miejski", EventDate = new DateTimeOffset(new DateTime(2023, 8, 12)), EmmissionT = 5 },
        new DbMassEvent { Id = Guid.NewGuid(), Name = "Kraków Music Festival", Place = "Stadion Miejski", EventDate = new DateTimeOffset(new DateTime(2024, 8, 10)), EmmissionT = 5 },
        new DbMassEvent { Id = Guid.NewGuid(), Name = "Kraków Christmas Market", Place = "Rynek Główny", EventDate = new DateTimeOffset(new DateTime(2023, 12, 1)), EmmissionT = 3 },
        new DbMassEvent { Id = Guid.NewGuid(), Name = "Kraków Christmas Market", Place = "Rynek Główny", EventDate = new DateTimeOffset(new DateTime(2024, 12, 1)), EmmissionT = 3 },
        new DbMassEvent { Id = Guid.NewGuid(), Name = "Kraków Food Festival", Place = "Park Jordana", EventDate = new DateTimeOffset(new DateTime(2023, 6, 20)), EmmissionT = 2 },
        new DbMassEvent { Id = Guid.NewGuid(), Name = "Kraków Food Festival", Place = "Park Jordana", EventDate = new DateTimeOffset(new DateTime(2024, 6, 15)), EmmissionT = 2 },
        new DbMassEvent { Id = Guid.NewGuid(), Name = "Kraków Film Festival", Place = "Centrum Kongresowe", EventDate = new DateTimeOffset(new DateTime(2023, 11, 5)), EmmissionT = 4 },
        new DbMassEvent { Id = Guid.NewGuid(), Name = "Kraków Film Festival", Place = "Centrum Kongresowe", EventDate = new DateTimeOffset(new DateTime(2024, 11, 3)), EmmissionT = 5 },
    };

    public static List<GreenArea> GreenAreas = new()
    {
        new GreenArea   { Name = "Park Jordana", Area = 21.50, Co2Absorption = 29.00 },
        new GreenArea   { Name = "Park Krakowski", Area = 25.00, Co2Absorption = 35.00 },
        new GreenArea   { Name = "Ogród Botaniczny UJ", Area = 7.00, Co2Absorption = 10.00 },
        new GreenArea   { Name = "Park Lotników Polskich", Area = 15.00, Co2Absorption = 20.00 },
        new GreenArea   { Name = "Park Miejski na Błoniach", Area = 15.00, Co2Absorption = 20.00 },
        new GreenArea   { Name = "Park Biedronki", Area = 3.00, Co2Absorption = 4.50 },
        new GreenArea   { Name = "Park Lecha Kaczyńskiego", Area = 8.00, Co2Absorption = 11.00 },
        new GreenArea   { Name = "Park Ratuszowy", Area = 2.50, Co2Absorption = 3.50 },
        new GreenArea   { Name = "Skwer W. Wawel", Area = 5.00, Co2Absorption = 7.00 },
        new GreenArea   { Name = "Park Szwedzki", Area = 6.00, Co2Absorption = 8.50 },
        new GreenArea   { Name = "Park Strzelecki", Area = 4.00, Co2Absorption = 6.00 },
        new GreenArea   { Name = "Las Wolski", Area = 30.00, Co2Absorption = 42.00 },
        new GreenArea   { Name = "Tereny zielone na Krowodrzy", Area = 10.00, Co2Absorption = 14.00 },
        new GreenArea   { Name = "Park na Dąbiu", Area = 4.50, Co2Absorption = 6.00 },
        new GreenArea   { Name = "Ogród Doświadczeń", Area = 1.00, Co2Absorption = 1.50 },
        new GreenArea   { Name = "Tereny zielone w Nowej Hucie", Area = 18.00, Co2Absorption = 25.00 },
        new GreenArea   { Name = "Tereny zielone w Podgórzu", Area = 12.00, Co2Absorption = 16.00 },
        new GreenArea   { Name = "Park im. Stanisława Wyspiańskiego", Area = 9.00, Co2Absorption = 12.00 },
        new GreenArea   { Name = "Tereny zielone w rejonie Salwatora", Area = 10.00, Co2Absorption = 14.00 },
        new GreenArea   { Name = "Zespół Parków Krajobrazowych w Krakowie", Area = 35.00, Co2Absorption = 49.00 }
    };
}
