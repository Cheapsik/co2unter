namespace co2unter.API.Models
{
    public class MassEvent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset EventDate { get; set; }
    }
}
