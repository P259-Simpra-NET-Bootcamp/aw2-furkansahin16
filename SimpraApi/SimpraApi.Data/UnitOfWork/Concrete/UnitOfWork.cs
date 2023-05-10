namespace SimpraApi.Data;
public class UnitOfWork : IUnitOfWork
{
    private readonly SimpraDbContext _context;
    private readonly Dictionary<Type, object> _repositories = new();
    private bool _disposed;
    public UnitOfWork(SimpraDbContext context)
    {
        this._context = context;
    }

    public IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity
    {
        var entityType = typeof(TEntity);
        if (!_repositories.ContainsKey(entityType))
        {
            var repositoryType = typeof(EfRepository<>).MakeGenericType(entityType);
            var instance = Activator.CreateInstance(repositoryType, _context);
            _repositories.Add(entityType, instance);
        }
        return (IRepository<TEntity>)_repositories[entityType];
    }
    private void Clean(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing) _context.Dispose();
        }
        _disposed = true;
        GC.SuppressFinalize(this);
    }

    public void Dispose()
    {
        Clean(true);
    }

    public async Task<DbUpdateException?> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            await _context.SaveChangesAsync(cancellationToken);
            return default;
        }
        catch (DbUpdateException ex)
        {
            return new DbUpdateException("An error is occured in saving process!" + ex.HelpLink);
        }
        finally
        {
            this.Dispose();
        }
    }

    public async Task<DbUpdateException?> SaveChangesAsyncWithTransaction(CancellationToken cancellationToken = default)
    {
        using (var transaction = await _context.Database.BeginTransactionAsync())
        {
            try
            {
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
                return default;
            }
            catch (DbUpdateException ex)
            {
                await transaction.RollbackAsync();
                return new DbUpdateException("An error is occured in saving process!" + ex.HelpLink);
            }
            finally
            {
                this.Dispose();
            }
        }
    }
}
