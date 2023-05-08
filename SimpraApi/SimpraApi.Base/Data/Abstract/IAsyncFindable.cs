using System.Linq.Expressions;

namespace SimpraApi.Base.Data;

public interface IAsyncFindable<TEntity> : IAsyncQueryable<TEntity>, IAsyncRepository where TEntity : IEntity
{
    Task<TEntity?> GetByIdAsync(Guid id, bool tracking = false);
    Task<bool> AnyAsync(Expression<Func<TEntity, bool>>? filter = null);
}


