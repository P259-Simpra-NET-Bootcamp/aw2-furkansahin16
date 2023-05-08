using SimpraApi.Base.Data;
using System.Linq.Expressions;

namespace SimpraApi.Base;
public class EfRepository<TEntity> : IAsyncRepository, IAsyncDeletable<TEntity>, IAsyncFindable<TEntity>, IAsyncInsertable<TEntity>, IAsyncQueryable<TEntity>, IAsyncUpdatable<TEntity>
    where TEntity : IEntity
{
    private readonly DbContext _context;
    public Task<TEntity> AddAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AnyAsync(Expression<Func<TEntity, bool>>? filter = null)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<TEntity>> GetAllAsync(bool tracking = false)
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter, bool tracking = false)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity?> GetByIdAsync(Guid id, bool tracking = false)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> UpdateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
