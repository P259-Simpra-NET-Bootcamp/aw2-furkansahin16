using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using SimpraApi.Data;

namespace SimpraApi.Service.Filters;
// TODO: İki kere db instance'ı alıp, iki kere id'ye göre buluyoruz. Kontrol et.
public class NotFoundFilter : ActionFilterAttribute
{
    private readonly SimpraDbContext _context;

    public NotFoundFilter(SimpraDbContext context)
    {
        _context = context;
    }
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var controllerName = context.Controller.GetType().Name;
        var modelName = controllerName.Replace("Controller", string.Empty);
        if (context.ActionDescriptor.Parameters.Any(x => x.Name == "id"))
        {
            int id = (int)context.ActionArguments["id"];

            var type = _context.Model.GetEntityTypes().FirstOrDefault(x => x.ClrType.Name == modelName)?.ClrType;

            var hasRecord = false;

            if (type is not null)
            {
                var dbSetMethod = typeof(DbContext).GetMethods().First(x => x.Name == "Set" && !x.GetParameters().Any()).MakeGenericMethod(type);
                var table = dbSetMethod.Invoke(_context, null);

                var findMethod = table.GetType().GetMethods().First(x => x.Name == "Find");
                hasRecord = findMethod.Invoke(table, new object[] { new object[] { id } }) != null;
            }

            if (!hasRecord) context.Result = new ObjectResult(new ErrorResponse(String.Format(Messages.GetError, modelName, id)));
        }
    }
}
