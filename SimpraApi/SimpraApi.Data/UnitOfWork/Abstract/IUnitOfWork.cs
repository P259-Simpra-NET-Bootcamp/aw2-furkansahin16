namespace SimpraApi.Data;
public interface IUnitOfWork : IDisposable
{
    Task<DbUpdateException?> SaveChangesAsync(CancellationToken cancellationToken = default);
    Task<DbUpdateException?> SaveChangesAsyncWithTransaction(CancellationToken cancellationToken = default);
}
