﻿namespace SimpraApi.Base;

public class ErrorDataResponse<T> : CommonDataResponse<T> where T : class
{
    public List<string> Errors { get; set; } = new();
    public ErrorDataResponse(T data) : base(false, data) { }
    public ErrorDataResponse(T data, string message) : base(false, data, message) { }
}


