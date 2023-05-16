using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using SimpraApi.Base.Utilities.Results;
using System.Net;

namespace SimpraApi.Service.Filters;

public class CacheResourceFilter : Attribute, IResourceFilter
{
    private readonly IMemoryCache _memoryCache;
    private readonly TimeSpan _cacheDuration;
    private readonly IConfiguration _configuration;
    private string? _cacheKey;

    public CacheResourceFilter(IMemoryCache memoryCache, IConfiguration configuration)
    {
        this._memoryCache = memoryCache;
        this._configuration = configuration;
        this._cacheDuration = TimeSpan.FromMinutes(_configuration.GetValue<int>("AppSettings:CacheDurationMinutes"));
    }

    public void OnResourceExecuted(ResourceExecutedContext context)
    {
        if (context.Result is ObjectResult objectResult
            && objectResult.Value is CommonResponse response
            && response.StatusCode == HttpStatusCode.OK)
        {
            _memoryCache.Set(this._cacheKey, response, this._cacheDuration);
        }
    }

    public void OnResourceExecuting(ResourceExecutingContext context)
    {
        this._cacheKey = GetCacheKey(context);

        if (_memoryCache.TryGetValue(this._cacheKey, out object cachedResult))
        {
            context.Result = new ObjectResult(cachedResult);
        }
    }

    private string GetCacheKey(ResourceExecutingContext context)
    {
        var cacheKey = $"{context.ActionDescriptor.RouteValues["controller"]}_{context.ActionDescriptor.RouteValues["action"]}";
        foreach (var argument in context.HttpContext.Request.RouteValues.Skip(2))
        {
            cacheKey += $"_{argument.Key}:'{argument.Value}'";
        }

        return cacheKey;
    }
}
