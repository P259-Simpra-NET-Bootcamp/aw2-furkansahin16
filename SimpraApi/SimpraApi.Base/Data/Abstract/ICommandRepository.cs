namespace SimpraApi.Base;
public interface ICommandRepository<TEntity>
{
    Task DeleteAsync(TEntity entity);
    Task<TEntity> AddAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);


}


