using System;
using co2unter.API.Infrastructure;
using co2unter.API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace co2unter.API.Repositories;

public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly Co2UnterDbContext _context;

    public GenericRepository(Co2UnterDbContext context)
    {
        _context = context;
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _context.Set<TEntity>().ToListAsync();
    }

    public async Task AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
    }

    public Task UpdateAsync(TEntity entity)
    {
        return Task.CompletedTask;
    }

    public Task RemoveAsync(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
        return Task.CompletedTask;
    }
}