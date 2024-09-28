namespace co2unter.API.Models;

public record TransportEmissionModel
{
    public string TransportType { get; init; } = default!;
    public double TotalCO2EmissionsKg { get; init; }
    public double TotalDistanceKm { get; init; }
    public int Year { get; init; }
}
