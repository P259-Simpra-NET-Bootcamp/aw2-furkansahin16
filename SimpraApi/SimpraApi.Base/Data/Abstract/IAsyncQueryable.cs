using System.Linq.Expressions;

namespace SimpraApi.Base.Data;
public interface IAsyncQueryable<TEntity> : IAsyncRepository where TEntity : IEntity
{
    Task<IEnumerable<TEntity>> GetAllAsync(bool tracking = true);
    Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity,bool>> filter ,bool tracking = true);

}


