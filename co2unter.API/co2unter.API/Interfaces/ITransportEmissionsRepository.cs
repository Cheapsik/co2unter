using co2unter.API.Infrastructure.Entities;
using co2unter.API.Models;

namespace co2unter.API.Interfaces;

public interface ITransportEmissionsRepository : IRepository<DbTransportEmission>
{
    Task<List<DbTransportEmission>> GetByYearAsync(int year);

    Task<List<int>> GetAvailableYearsAsync();
}