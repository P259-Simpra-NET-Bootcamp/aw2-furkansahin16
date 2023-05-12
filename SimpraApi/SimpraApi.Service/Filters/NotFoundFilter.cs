using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using SimpraApi.Data;

namespace SimpraApi.Service.Filters;
// TODO: Aynı veriyi hem serviste hem filter'da iki database'den arıyoruz. Kontrol et maliyetli mi?
public class NotFoundFilter : ActionFilterAttribute
{
    private readonly SimpraDbContext _context;
    private string ModelName = string.Empty;
    private object? Table;

    public NotFoundFilter(SimpraDbContext context)
    {
        _context = context;
    }
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var controllerName = context.Controller.GetType().Name;
        this.ModelName = controllerName.Replace("Controller", string.Empty);
        var entityType = _context.Model.GetEntityTypes().FirstOrDefault(x => x.ClrType.Name == this.ModelName)!.ClrType;
        var dbSetMethod = typeof(DbContext).GetMethods().First(x => x.Name == "Set" && !x.GetParameters().Any()).MakeGenericMethod(entityType);
        this.Table = dbSetMethod.Invoke(_context, null)!;

        switch (context.HttpContext.Request.Method)
        {
            case "GET": CheckEntityFromQuery(context); break;
            case "PUT": CheckEntityFromBody(context); break;
        }
    }

    private void CheckEntityFromBody(ActionExecutingContext context)
    {
        if (!context.ActionDescriptor.Parameters.Any(x => x.Name == "request"))
        {
            var request = context.ActionArguments["request"] as IBaseUpdateRequest;
            context.Result = CheckIfExist(request!.Id);
        }
    }

    private void CheckEntityFromQuery(ActionExecutingContext context)
    {
        if (context.ActionDescriptor.Parameters.Any(x => x.Name == "id"))
        {
            if (!context.ActionArguments.Any(x => x.Key == "id"))
            {
                context.Result = new BadRequestResult();
                return;
            }
            int id = (int)context.ActionArguments["id"]!;

            context.Result = CheckIfExist(id);
        }
    }

    private ObjectResult? CheckIfExist(int id)
    {
        var findMethod = this.Table!.GetType().GetMethods().First(x => x.Name == "Find");
        var entity = findMethod.Invoke(this.Table, new object[] { new object[] { id } });
        return (entity is null)
            ? new ObjectResult(new ErrorResponse(String.Format(Messages.GetError, this.ModelName, id)))
            : default;
    }
}
