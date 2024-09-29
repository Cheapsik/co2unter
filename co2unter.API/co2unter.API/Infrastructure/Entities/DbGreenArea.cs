namespace co2unter.API.Infrastructure.Entities
{
    public class DbGreenArea
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double Co2Absorption { get; set; }

        public DbGreenArea()
        {
            
        }

        public DbGreenArea(Guid id, string name, double area, double co2Absorption) 
        {
            Id = id;
            Name = name;
            Area = area;
            Co2Absorption = co2Absorption;
        }

        public DbGreenArea(string name, double area, double co2Absorption)
            => new DbGreenArea(Guid.NewGuid(), name, area, co2Absorption);
    }
}
