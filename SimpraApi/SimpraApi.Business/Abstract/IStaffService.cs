namespace SimpraApi.Business;
// TODO : Method summary'leri unutma
public interface IStaffService
{
    Task<IResponse> CreateStaffAsync(StaffCreateRequest request);
    Task<IResponse> CreateStaffAsync(params StaffCreateRequest[] request);
    Task<IResponse> UpdateStaffAsync(StaffUpdateRequest request);
    Task<IResponse> DeleteStaffByIdAsync(int id);
    Task<IResponse> GetAllAsync();
    Task<IResponse> GetAllByFilter(StaffFilter filter);
    Task<IResponse> GetByIdAsync(int id);
}
