namespace SimpraApi.Base.Data;
public interface IAsyncUpdatable<TEntity> : IAsyncRepository where TEntity : IEntity
{
    Task<TEntity> UpdateAsync(TEntity entity);
}


