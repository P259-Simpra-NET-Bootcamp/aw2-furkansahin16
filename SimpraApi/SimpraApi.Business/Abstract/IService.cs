namespace SimpraApi.Business;
public interface IService
{
    Task<IResponse> GetByIdAsync(int id);
}
