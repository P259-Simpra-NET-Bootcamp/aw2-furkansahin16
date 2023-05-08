namespace SimpraApi.Data;
public class StaffRepository : EfRepository<Staff>, IStaffRepository
{
	public StaffRepository(SimpraDbContext context) : base(context) { }
}
