using co2unter.API.Infrastructure.Entities;
using co2unter.API.Models;

namespace co2unter.API.Interfaces
{
    public interface IServiceEmissionsRepository : IRepository<ServiceEmission>
    {
        Task<List<ServiceEmission>> GetByYearAsync(int year);

        Task<List<int>> GetAvailableYearsAsync();
    }
}
