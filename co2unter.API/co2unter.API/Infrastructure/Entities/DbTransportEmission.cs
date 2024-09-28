namespace co2unter.API.Infrastructure.Entities;

public class DbTransportEmission
{
    public string TransportType { get; set; } = default!;
    public double TotalCO2EmissionsKg { get; set; }
    public double TotalDistanceKm { get; set; }
    public int Year { get; set; }

    public DbTransportEmission()
    {

    }

    public DbTransportEmission(string transportType, double totalCO2EmissionsKg, double totalDistanceKm, int year)
    {
        TransportType = transportType;
        TotalCO2EmissionsKg = totalCO2EmissionsKg;
        TotalDistanceKm = totalDistanceKm;
        Year = year;
    }
}
