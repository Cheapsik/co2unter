using co2unter.API.Models;

namespace co2unter.API.Interfaces
{
    public interface IMassEventService
    {
        public Task<MassEvent?> GetMassEventByIdAsync(Guid massEventId);
        public Task<List<MassEvent>> GetAllMassEvents();
        public Task<List<MassEvent>> BrowseMassEvents();
        public Task<Guid> AddMassEventAsync(MassEvent massEvent);
    }
}
