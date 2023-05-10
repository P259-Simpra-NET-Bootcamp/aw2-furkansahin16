﻿namespace SimpraApi.Base.Utilities.Results;

public abstract class CommonDataResponse<T> : CommonResponse, IDataResponse<T> 
    where T : BaseResponse, IEnumerable<BaseResponse>
{
    public T Data { get; set; } = null!;
    public CommonDataResponse(bool isSuccess, T data) : base(isSuccess) => this.Data = data;
    public CommonDataResponse(bool isSuccess, T data, string message) : base(isSuccess, message) => this.Data = data;
}
