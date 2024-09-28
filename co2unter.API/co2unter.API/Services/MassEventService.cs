using co2unter.API.Interfaces;
using co2unter.API.Models;

namespace co2unter.API.Services
{
    public class MassEventService : IMassEventService
    {
        private static List<MassEvent> massEvents = new List<MassEvent>();

        public MassEventService()
        {
            
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
            return massEvents;
        }

        public async Task<Guid> AddMassEventAsync(MassEvent massEvent)
        {
            massEvent.Id = Guid.NewGuid();
            massEvents.Add(massEvent);

            return massEvent.Id.Value;
        }
    }
}
