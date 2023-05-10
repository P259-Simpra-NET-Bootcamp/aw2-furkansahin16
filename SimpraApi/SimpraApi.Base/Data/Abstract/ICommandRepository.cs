namespace SimpraApi.Base;
public interface ICommandRepository<TEntity> where TEntity : BaseEntity
{
    Task DeleteAsync(TEntity entity);
    Task<TEntity> AddAsync(TEntity entity);
    Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities);
    Task<TEntity> UpdateAsync(TEntity entity);
}


