namespace SimpraApi.Data;
public class SimpraDbContext : DbContext
{
	public SimpraDbContext(DbContextOptions<SimpraDbContext> options) : base(options)
	{

	}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Staff> Staff { get; set; }
	
}
