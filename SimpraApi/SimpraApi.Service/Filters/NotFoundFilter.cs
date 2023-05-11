using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SimpraApi.Service.Filters;
public class NotFoundFilter : IAsyncActionFilter
{
    private readonly IService _service;

    public NotFoundFilter(IService service)
    {
        _service = service;
    }
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        var controllerName = context.Controller.GetType().Name;
        var modelName = controllerName.Replace("Controller", string.Empty);
        if (context.ActionDescriptor.Parameters.Any(x => x.Name == "id"))
        {
            int id = (int)context.ActionArguments["id"];

            var model = await _service.GetByIdAsync(id);

            if (model is null) context.Result = new ObjectResult(new ErrorResponse(String.Format(Messages.GetError, modelName, id)));
        }
        await next();
    }
}
