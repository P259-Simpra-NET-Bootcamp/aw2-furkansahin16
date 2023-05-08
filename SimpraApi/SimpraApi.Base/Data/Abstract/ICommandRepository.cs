namespace SimpraApi.Base;
public interface ICommandRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    Task DeleteAsync(TEntity entity);
    Task<TEntity> AddAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
}


