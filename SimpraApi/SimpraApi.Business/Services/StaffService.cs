namespace SimpraApi.Business.Services;
public class StaffService : IStaffService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepository<Staff> _repository;
    private readonly IMapper _mapper;
    public StaffService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this._unitOfWork = unitOfWork;
        this._repository = _unitOfWork.GetRepository<Staff>();
        _mapper = mapper;
    }

    public async Task<IResponse> CreateStaff(StaffRequest request)
    {
        var model = _mapper.Map<Staff>(request);
        await _repository.AddAsync(model);
        await _unitOfWork.SaveChangesAsync();

        return new SuccessDataResponse<StaffResponse>(_mapper.Map<StaffResponse>(model), "Staff is added successfully");
    }
    public async Task<IResponse> CreateStaff(params StaffRequest[] request)
    {
        var models = _mapper.Map<List<Staff>>(request);
        await _repository.AddRangeAsync(models);
        await _unitOfWork.SaveChangesAsyncWithTransaction();

        return new SuccessDataResponse<IEnumerable<StaffResponse>>(_mapper.Map<List<StaffResponse>>(models), "Staffs are added successfully");
    }
    public async Task<IResponse> UpdateStaff(StaffRequest request)
    {
        var model = _mapper.Map<Staff>(request);
        await _repository.UpdateAsync(model);
        await _unitOfWork.SaveChangesAsync();

        return new SuccessDataResponse<StaffResponse>(_mapper.Map<StaffResponse>(model), "Staff is updated successfully");
    }

    public async Task<IResponse> DeleteStaffByIdAsync(int id)
    {
        var model = await _repository.GetAsync(x => x.Id == id);
        if (model is null) return new ErrorResponse("Staff not found");

        await _repository.DeleteAsync(model);
        return new SuccessResponse("Staff is deleted");
    }

    public async Task<IResponse> GetAllAsync()
    {
        if (await _repository.AnyAsync()) return new ErrorResponse("No data found");

        var models = await _repository.GetAllAsync(false);
        return new SuccessDataResponse<IEnumerable<StaffResponse>>(_mapper.Map<List<StaffResponse>>(models), "Data is successfully retrieved");
    }

    public Task<IResponse> GetAllByLastNameAndCountry(string lastName, string country)
    {
        throw new NotImplementedException();
    }

    public async Task<IResponse> GetByIdAsync(int id)
    {
        var model = await _repository.GetAsync(x => x.Id == id);
        if (model is null) return new ErrorResponse("Staff not found");

        return new SuccessDataResponse<StaffResponse>(_mapper.Map<StaffResponse>(model), "Staff is successfully retrieved");
    }
}
