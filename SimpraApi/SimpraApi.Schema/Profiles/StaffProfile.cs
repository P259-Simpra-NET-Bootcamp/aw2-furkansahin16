namespace SimpraApi.Schema;
public class StaffProfile : Profile
{
	public StaffProfile()
	{
		CreateMap<StaffRequest, Staff>();
		CreateMap<Staff, StaffResponse>();
	}
}
