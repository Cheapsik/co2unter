namespace co2unter.API.Models
{
    public class ActualCarbonEmissionResponse
    {
        public int CarbonEmissionG {  get; set; }
        public int CarbonEmissionKg {  get; set; }
        public DateTimeOffset DateTime { get; set; }
    }
}
