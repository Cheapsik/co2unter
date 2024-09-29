using co2unter.API.Infrastructure.Entities;

namespace co2unter.API.Models
{
    public class GreenArea
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public double Area { get; set; }
        public double Co2Absorption { get; set; }

        public GreenArea()
        {
            
        }
    }
}
