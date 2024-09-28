namespace co2unter.API.Models;

public record ServiceEmissionModel
{
    public string ServiceType { get; init; } = default!;
    public double TotalCO2EmissionsKg { get; init; }
    public int Year { get; init; }
}