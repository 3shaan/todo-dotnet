using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Todo.Domain.RepositoryInterface;
using Todo.Infra.Persistance.Entities;

namespace Todo.Infra.Repository;


public class GenericRepository<TDomain, TEntity>(TodoDbContext dbContext, IMapper mapper) : IGenericRepository<TDomain>
where TDomain : class
where TEntity : class
{
    public async Task AddAsync(TDomain domain)
    {
        var entity = mapper.Map<TEntity>(domain);
        await dbContext.Set<TEntity>().AddAsync(entity);
    }

    public Task<int> CommitAsync()
    {
        return dbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<TDomain>> GetAllAsync()
    {
        var entities = await dbContext.Set<TEntity>().ToListAsync();
        return mapper.Map<List<TDomain>>(entities);
    }

    public async Task<TDomain?> GetByIdAsync(object id)
    {
        var entity = await dbContext.Set<TEntity>().FindAsync(id);
        return entity is null ? null : mapper.Map<TDomain>(entity);
    }
}
