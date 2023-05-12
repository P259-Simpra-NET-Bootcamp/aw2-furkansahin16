﻿using Microsoft.AspNetCore.Mvc;

namespace SimpraApi.Service.Controllers;
// TODO : Filter Apisi yazılacak
public class StaffController : BaseApiController
{
    private readonly IStaffService _staffService;

    public StaffController(IStaffService staffService)
    {
        _staffService = staffService;
    }

    [ServiceFilter(typeof(NotFoundFilter))]
    [HttpGet("{id}")]
    public async Task<IResponse> GetStaff(int id)
    {
        return await _staffService.GetByIdAsync(id);
    }
    [HttpGet]
    public async Task<IResponse> GetAll()
    {
        return await _staffService.GetAllAsync();
    }
    [CustomValidate(typeof(StaffCreateRequestValidator))]
    [ServiceFilter(typeof(EmailFilter))]
    [HttpPost]
    public async Task<IResponse> Add(StaffCreateRequest request)
    {
        return await _staffService.CreateStaffAsync(request);
    }
    [ServiceFilter(typeof(NotFoundFilter))]
    [CustomValidate(typeof(StaffUpdateRequestValidator))]
    [ServiceFilter(typeof(EmailFilter))]
    [HttpPut]
    public async Task<IResponse> Update(StaffUpdateRequest request)
    {
        return await _staffService.UpdateStaffAsync(request);
    }
    [ServiceFilter(typeof(NotFoundFilter))]
    [HttpDelete]
    public async Task<IResponse> Delete(int id)
    {
        return await _staffService.DeleteStaffByIdAsync(id);
    }
}
