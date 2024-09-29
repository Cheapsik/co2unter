using co2unter.API.Infrastructure.Entities;
using co2unter.API.Models;

namespace co2unter.API.Interfaces
{
    public interface IServiceEmissionsRepository : IRepository<DbServiceEmission>
    {
        Task<List<DbServiceEmission>> GetByYearAsync(int year);

        Task<List<int>> GetAvailableYearsAsync();
    }
}
