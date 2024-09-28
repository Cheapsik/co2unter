using co2unter.API.Infrastructure.Entities;

namespace co2unter.API.Interfaces;

public interface IMassEventRepository : IRepository<DbMassEvent>
{
    public Task<DbMassEvent?> GetMassEventByIdAsync(Guid massEventId);
}
