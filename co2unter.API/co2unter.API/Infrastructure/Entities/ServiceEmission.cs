namespace co2unter.API.Infrastructure.Entities;

public class ServiceEmission
{
    public string ServiceType { get; set; } = default!;
    public double TotalCO2EmissionsKg { get; set; }
    public int Year { get; set; }

    public ServiceEmission()
    {

    }

    public ServiceEmission(string serviceType, double totalCO2EmissionsKg, int year)
    {
        ServiceType = serviceType;
        TotalCO2EmissionsKg = totalCO2EmissionsKg;
        Year = year;
    }
}
