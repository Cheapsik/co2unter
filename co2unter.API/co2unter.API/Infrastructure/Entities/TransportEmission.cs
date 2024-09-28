namespace co2unter.API.Infrastructure.Entities;

public class TransportEmission
{
    public string TransportType { get; private set; } = default!;
    public double TotalCO2EmissionsKg { get; private set; }
    public double TotalDistanceKm { get; private set; }
    public int Year { get; private set; }

    public TransportEmission()
    {

    }

    public TransportEmission(string transportType, double totalCO2EmissionsKg, double totalDistanceKm, int year)
    {
        TransportType = transportType;
        TotalCO2EmissionsKg = totalCO2EmissionsKg;
        TotalDistanceKm = totalDistanceKm;
        Year = year;
    }
}
