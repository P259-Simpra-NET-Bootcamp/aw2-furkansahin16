using System.Linq.Expressions;

namespace SimpraApi.Base.Data;

public interface IAsyncQueryable<TEntity> : IAsyncRepository where TEntity : IEntity
{
    Task<IQueryable<TEntity>> GetAllAsync(bool tracking = false);
    Task<IQueryable<TEntity>> GetAllAsync(Expression<Func<TEntity,bool>> filter ,bool tracking = false);

}


