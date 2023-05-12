using System.Linq.Expressions;

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
        var model = await _repository.GetAsync(x => x.Id == id, false);

        return new SuccessDataResponse<StaffResponse>(_mapper.Map<StaffResponse>(model), String.Format(Messages.GetSuccess, ModelName));
    }

    public async Task<IResponse> GetAllByFilter(StaffFilter filter)
    {
        var expressions = new List<Expression<Func<Staff, bool>>>();

        expressions.Add(x => x.LastName.ToLower().Contains(filter.LastName?? ""));
        expressions.Add(x => x.Country.ToLower().Contains(filter.Country ?? ""));

        var finalExpression = expressions.Aggregate((Expression<Func<Staff, bool>>)null, (current, expression) =>
        {
            if (current == null) return expression;
            var invoked = Expression.Invoke(expression, current.Parameters);
            return Expression.Lambda<Func<Staff, bool>>(Expression.AndAlso(current.Body, invoked), current.Parameters);
        });

        var models = await _repository.GetAllAsync(finalExpression, false);
        return models.Any()
            ? new SuccessDataResponse<IEnumerable<StaffResponse>>(_mapper.Map<List<StaffResponse>>(models),String.Format(Messages.ListSuccess, ModelName))
            : new ErrorResponse(String.Format(Messages.ListError, ModelName));
    }
}
