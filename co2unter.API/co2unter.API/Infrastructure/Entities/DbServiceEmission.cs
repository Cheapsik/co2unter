namespace co2unter.API.Infrastructure.Entities;

public class DbServiceEmission
{
    public string ServiceType { get; set; } = default!;
    public double TotalCO2EmissionsKg { get; set; }
    public int Year { get; set; }

    public DbServiceEmission()
    {

    }

    public DbServiceEmission(string serviceType, double totalCO2EmissionsKg, int year)
    {
        ServiceType = serviceType;
        TotalCO2EmissionsKg = totalCO2EmissionsKg;
        Year = year;
    }
}
