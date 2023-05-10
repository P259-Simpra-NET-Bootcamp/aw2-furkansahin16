namespace SimpraApi.Business;

public interface IStaffService
{
    Task<IResponse> CreateStaff(StaffRequest request);
    Task<IResponse> CreateStaff(params StaffRequest[] request);
    Task<IResponse> UpdateStaff(StaffRequest request);
    Task<IResponse> DeleteStaffByIdAsync(int id);
    Task<IResponse> GetByIdAsync(int id);
    Task<IResponse> GetAllAsync();
    Task<IResponse> GetAllByLastNameAndCountry(string lastName, string country);
}
