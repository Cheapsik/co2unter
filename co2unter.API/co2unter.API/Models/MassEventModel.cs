namespace co2unter.API.Models
{
    public class MassEventModel
    {
        public Guid? Id { get; set; }
        public string Name { get; set; } = default!;
        public string Place { get; set; } = default!;
        public DateTimeOffset EventDate { get; set; }
        public int EmmissionT {  get; set; }
    }
}
