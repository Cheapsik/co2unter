using System.Xml.Linq;

namespace co2unter.API.Infrastructure.Entities
{
    public class DbMassEvent
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public DateTimeOffset EventDate { get; set; }
        public int EmmissionT { get; set; }

        public DbMassEvent(Guid id, string name, string place, DateTimeOffset eventDate, int emmissionT)
        {
            Id = id;
            Name = name;
            Place = place;
            EventDate = eventDate;
            EmmissionT = emmissionT;
        }

        public DbMassEvent(string name, string place, DateTimeOffset eventDate, int EmmissionT)
            => new DbMassEvent(Guid.NewGuid(), name, place, eventDate, EmmissionT);



    }
}
