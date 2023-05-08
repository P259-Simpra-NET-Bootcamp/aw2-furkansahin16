namespace SimpraApi.Base.Data;
public interface IAsyncInsertable<TEntity> : IAsyncRepository where TEntity : IEntity
{
    Task<TEntity> AddAsync(TEntity entity);
}


