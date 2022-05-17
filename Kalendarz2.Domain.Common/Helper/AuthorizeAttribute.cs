using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Request.Body.Peeker;
using System.Text;

namespace Kalendarz2.Domain.Common.Helper;
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeAttribute : Attribute, IAuthorizationFilter
{
    public async void OnAuthorization(AuthorizationFilterContext context)
    {
        var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
        if (allowAnonymous)
            return;

        var user = (UserAuthorizeDTO)context.HttpContext.Items["User"];
        if (user == null)
            context.Result = new JsonResult(new { message = "Unauthorized" })
            { StatusCode = StatusCodes.Status401Unauthorized };

        //context.HttpContext.Request.EnableBuffering();
        //using var reader = new StreamReader(
        //    context.HttpContext.Request.Body,
        //    Encoding.UTF8,
        //    false,
        //    -1,
        //    true);
        var body = context.HttpContext.Request.PeekBody();
        //context.HttpContext.Request.Body.Position = 0;
        var authorId = JsonConvert.DeserializeObject<NewEventDTO>(body).AuthorId;
        if (authorId != user?.Id)
            context.Result = new JsonResult(new { message = "Unauthorized" })
            { StatusCode = StatusCodes.Status401Unauthorized };
    }
}
