namespace SimpraApi.Business;

public interface IStaffService : IService
{
    Task<IResponse> CreateStaffAsync(StaffCreateRequest request);
    Task<IResponse> CreateStaffAsync(params StaffCreateRequest[] request);
    Task<IResponse> UpdateStaffAsync(StaffUpdateRequest request);
    Task<IResponse> DeleteStaffByIdAsync(int id);
    Task<IResponse> GetAllAsync();
}
