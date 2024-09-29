using System.Xml.Linq;
using co2unter.API.Infrastructure.Entities;
using co2unter.API.Models;

namespace co2unter.CLI;

public static class SeedData
{
    public static List<DbServiceEmission> ServiceEmissions = new()
    {
        new DbServiceEmission
        {
            ServiceType  = "gastronomy",
            TotalCO2EmissionsKg  = 150.0,
            Year  = 2024
        },
        new DbServiceEmission
        {
            ServiceType  = "hospitality",
            TotalCO2EmissionsKg  = 200.0,
            Year  = 2024
        },
        new DbServiceEmission
        {
            ServiceType  = "trade",
            TotalCO2EmissionsKg  = 180.0,
            Year  = 2024
        },
        new DbServiceEmission
        {
            ServiceType  = "gastronomy",
            TotalCO2EmissionsKg  = 140.0,
            Year  = 2023
        },
        new DbServiceEmission
        {
            ServiceType  = "hospitality",
            TotalCO2EmissionsKg  = 210.0,
            Year  = 2023
        },
        new DbServiceEmission
        {
            ServiceType  = "trade",
            TotalCO2EmissionsKg  = 175.0,
            Year  = 2023
        }
    };

    public static List<DbTransportEmission> TransportEmissions = new()
    {
        new DbTransportEmission
        {
            TransportType  = "car",
            TotalCO2EmissionsKg  = 250.0,
            TotalDistanceKm  = 1500.0,
            Year  = 2024
        },
        new DbTransportEmission
        {
            TransportType  = "car",
            TotalCO2EmissionsKg  = 220.0,
            TotalDistanceKm  = 1400.0,
            Year  = 2023
        },
        new DbTransportEmission
        {
            TransportType  = "public transport",
            TotalCO2EmissionsKg  = 75.0,
            TotalDistanceKm  = 1200.0,
            Year  = 2024
        },
        new DbTransportEmission
        {
            TransportType  = "public transport",
            TotalCO2EmissionsKg  = 80.0,
            TotalDistanceKm  = 1300.0,
            Year  = 2023
        },
        new DbTransportEmission
        {
            TransportType  = "bike",
            TotalCO2EmissionsKg  = 0.0,
            TotalDistanceKm  = 500.0,
            Year  = 2024
        },
        new DbTransportEmission
        {
            TransportType  = "bike",
            TotalCO2EmissionsKg  = 0.0,
            TotalDistanceKm  = 400.0,
            Year  = 2023
        },
        new DbTransportEmission
        {
            TransportType  = "walking",
            TotalCO2EmissionsKg  = 0.0,
            TotalDistanceKm  = 300.0,
            Year  = 2024
        },
        new DbTransportEmission
        {
            TransportType  = "walking",
            TotalCO2EmissionsKg  = 0.0,
            TotalDistanceKm  = 250.0,
            Year  = 2023
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
