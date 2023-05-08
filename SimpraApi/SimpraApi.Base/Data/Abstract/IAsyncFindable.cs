using System.Linq.Expressions;

namespace SimpraApi.Base.Data;
public interface IAsyncFindable<TEntity> : IAsyncQueryable<TEntity>, IAsyncRepository where TEntity : IEntity
{
    Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> expression, bool tracking = true);
    Task<TEntity?> GetByIdAsync(Guid id, bool tracking = true);
    Task<bool> AnyAsync(Expression<Func<TEntity, bool>>? filter = null);
}


