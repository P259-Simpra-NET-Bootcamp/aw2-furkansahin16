namespace SimpraApi.Schema;
public class StaffProfile : Profile
{
	public StaffProfile()
	{
		CreateMap<StaffCreateRequest, Staff>();
		CreateMap<StaffUpdateRequest, Staff>();
		CreateMap<Staff, StaffResponse>();
	}
}
