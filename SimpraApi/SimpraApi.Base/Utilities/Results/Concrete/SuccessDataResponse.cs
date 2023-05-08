namespace SimpraApi.Base;

public class SuccessDataResponse<T> : CommonDataResponse<T> where T : class
{
    public SuccessDataResponse(T data) : base(true, data) { }
    public SuccessDataResponse(T data, string message) : base(true, data, message) { }
}


