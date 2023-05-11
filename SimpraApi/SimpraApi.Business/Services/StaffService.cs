namespace SimpraApi.Business.Services;
public class StaffService : IStaffService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepository<Staff> _repository;
    private readonly IMapper _mapper;
    private readonly string ModelName = typeof(Staff).Name;
    public StaffService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this._unitOfWork = unitOfWork;
        this._repository = _unitOfWork.GetRepository<Staff>();
        _mapper = mapper;
    }
    public async Task<IResponse> CreateStaffAsync(StaffCreateRequest request)
    {
        var model = _mapper.Map<Staff>(request);
        await _repository.AddAsync(model);
        await _unitOfWork.SaveChangesAsync();

        return new SuccessDataResponse<StaffResponse>(_mapper.Map<StaffResponse>(model), String.Format(Messages.AddSuccess, ModelName));
    }
    public async Task<IResponse> CreateStaffAsync(params StaffCreateRequest[] request)
    {
        var models = _mapper.Map<List<Staff>>(request);
        await _repository.AddRangeAsync(models);
        await _unitOfWork.SaveChangesAsyncWithTransaction();

        return new SuccessDataResponse<IEnumerable<StaffResponse>>(_mapper.Map<List<StaffResponse>>(models), String.Format(Messages.AddRangeSuccess, ModelName));
    }
    public async Task<IResponse> UpdateStaffAsync(StaffUpdateRequest request)
    {
        var model = _mapper.Map<Staff>(request);
        await _repository.UpdateAsync(model);
        await _unitOfWork.SaveChangesAsync();

        return new SuccessDataResponse<StaffResponse>(_mapper.Map<StaffResponse>(model), String.Format(Messages.UpdateSuccess, ModelName));
    }

    public async Task<IResponse> DeleteStaffByIdAsync(int id)
    {
        var model = await _repository.GetAsync(x => x.Id == id);
        await _repository.DeleteAsync(model!);
        await _unitOfWork.SaveChangesAsync();

        return new SuccessResponse(String.Format(Messages.DeleteSuccess, ModelName));
    }

    public async Task<IResponse> GetAllAsync()
    {
        if (!await _repository.AnyAsync()) return new ErrorResponse(String.Format(Messages.ListError, ModelName));

        var models = await _repository.GetAllAsync(false);

        return new SuccessDataResponse<IEnumerable<StaffResponse>>(_mapper.Map<List<StaffResponse>>(models), String.Format(Messages.ListSuccess, ModelName));
    }

    public async Task<IResponse> GetByIdAsync(int id)
    {
        var model = await _repository.GetAsync(x => x.Id == id,false);

        return new SuccessDataResponse<StaffResponse>(_mapper.Map<StaffResponse>(model), String.Format(Messages.GetSuccess, ModelName));
    }
}
