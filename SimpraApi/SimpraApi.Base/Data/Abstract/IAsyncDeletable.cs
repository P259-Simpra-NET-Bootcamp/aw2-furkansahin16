namespace SimpraApi.Base.Data;

public interface IAsyncDeletable<TEntity> : IAsyncRepository where TEntity : IEntity
{
    Task DeleteAsync(TEntity entity);
}


