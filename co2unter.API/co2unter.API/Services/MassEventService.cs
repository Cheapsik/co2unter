using co2unter.API.Interfaces;
using co2unter.API.Models;

namespace co2unter.API.Services
{
    public class MassEventService : IMassEventService
    {
        private static List<MassEvent> massEvents = new List<MassEvent>();

        public MassEventService()
        {
            if(massEvents.Count == 0)
                MassEventsSeed();   
        }

        public async Task<MassEvent?> GetMassEventByIdAsync(Guid massEventId)
        {
            return massEvents.FirstOrDefault(me => me.Id == massEventId);
        }

        public async Task<List<MassEvent>> BrowseMassEvents()
        {
            throw new NotImplementedException();
        }

        public async Task<List<MassEvent>> GetAllMassEvents()
        {
            return massEvents.OrderBy(me => me.EventDate).ToList();
        }

        public async Task<Guid> AddMassEventAsync(MassEvent massEvent)
        {
            massEvent.Id = Guid.NewGuid();
            massEvents.Add(massEvent);

            return massEvent.Id.Value;
        }

        private void MassEventsSeed()
        {
            massEvents.AddRange(new List<MassEvent>()
            {
                new MassEvent() { Id = Guid.NewGuid(), EventDate = DateTime.Now, Name = "XD1", EmmissionT = 100, Place = "Tama" },
                new MassEvent() { Id = Guid.NewGuid(), EventDate = DateTime.Now.AddDays(-2), Name = "XD2", EmmissionT = 10, Place = "Tauron Arena" },
                new MassEvent() { Id = Guid.NewGuid(), EventDate = DateTime.Now.AddDays(-3), Name = "XD2_1", EmmissionT = 10, Place = "slumsy" },
                new MassEvent() { Id = Guid.NewGuid(), EventDate = DateTime.Now, Name = "XD1_1", EmmissionT = 242, Place = "Bulwary" },
                new MassEvent() { Id = Guid.NewGuid(), EventDate = DateTime.Now.AddYears(-1), Name = "XD3", EmmissionT = 20, Place = "Tama" },
                new MassEvent() { Id = Guid.NewGuid(), EventDate = DateTime.Now.AddDays(-4), Name = "XD2_2", EmmissionT = 10, Place = "Stadion" },
            });
        }
    }
}
