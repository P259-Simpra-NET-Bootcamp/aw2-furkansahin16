using Microsoft.AspNetCore.Mvc;

namespace SimpraApi.Service.Controllers;

public class StaffController : BaseApiController
{
    private readonly IStaffService _staffService;

    public StaffController(IStaffService staffService)
    {
        _staffService = staffService;
    }

    [HttpGet("{id}")]
    [ServiceFilter(typeof(NotFoundFilter))]
    public async Task<IResponse> GetStaff(int id)
    {
        return await _staffService.GetByIdAsync(id);
    }
    [HttpGet]
    public async Task<IResponse> GetAll()
    {
        return await _staffService.GetAllAsync();
    }
    [HttpPost]
    [CustomValidate(typeof(StaffCreateRequestValidator))]
    public async Task<IResponse> Add(StaffCreateRequest request)
    {
        return await _staffService.CreateStaffAsync(request);
    }
    [HttpPut]
    [CustomValidate(typeof(StaffUpdateRequestValidator))]
    public async Task<IResponse> Update(StaffUpdateRequest request)
    {
        return await _staffService.UpdateStaffAsync(request);
    }
    [HttpDelete]
    [ServiceFilter(typeof(NotFoundFilter))]
    public async Task<IResponse> Delete(int id)
    {
        return await _staffService.DeleteStaffByIdAsync(id);
    }
}
