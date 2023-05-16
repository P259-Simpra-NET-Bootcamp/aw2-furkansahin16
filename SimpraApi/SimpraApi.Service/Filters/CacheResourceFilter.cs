using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using SimpraApi.Base.Utilities.Results;
using System.Net;
using System.Reflection;

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
        if (string.Equals(context.HttpContext.Request.Method, "GET", StringComparison.OrdinalIgnoreCase))
        {
            if (context.Result is ObjectResult result && result.Value is CommonResponse response && response.IsSuccess)
            {
                _memoryCache.Set(this._cacheKey, response, this._cacheDuration);
            }
        }
        else
        {
            if (context.Result is ObjectResult result && result.Value is CommonResponse response && response.IsSuccess)
            {
                ClearCache();
            }
        }

    }

    public void OnResourceExecuting(ResourceExecutingContext context)
    {
        if (string.Equals(context.HttpContext.Request.Method, "GET", StringComparison.OrdinalIgnoreCase))
        {
            this._cacheKey = GetCacheKey(context);

            if (_memoryCache.TryGetValue(this._cacheKey, out object cachedResult))
            {
                context.Result = new ObjectResult(cachedResult);
            }
        }
    }

    private string GetCacheKey(ResourceExecutingContext context)
    {
        var cacheKey = $"{context.ActionDescriptor.RouteValues["controller"]}_{context.ActionDescriptor.RouteValues["action"]}";
        foreach (var argument in context.HttpContext.Request.RouteValues.Skip(2))
        {
            cacheKey += $"_{argument.Key}:'{argument.Value}'";
        }
        foreach(var query in context.HttpContext.Request.Query)
        {
            cacheKey += $"_{query.Key}:'{query.Value}'";
        }

        return cacheKey;
    }

    private void ClearCache()
    {
        Type T = _memoryCache.GetType();
        PropertyInfo prop = T!.GetProperty("EntriesCollection", BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.NonPublic | BindingFlags.Public)!;
        object innerCache = prop.GetValue(_memoryCache)!;
        Type T2 = innerCache.GetType();
        MethodInfo clearMethod = T2.GetMethod("Clear", BindingFlags.Instance | BindingFlags.Public)!;
        clearMethod.Invoke(innerCache, null);
    }
}
