using Kalendarz2.Domain.Common.Utils;
using Kalendarz2.Domain.Interfaces.Facades;
using Microsoft.AspNetCore.Http;

namespace Kalendarz2.Domain.Facades.Middleware;

public class JwtMiddleware
{
    private readonly RequestDelegate _next;

    public JwtMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context, IJwtUtils jwtUtils, IAccountFcd accountFcd)
    {
        var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
        var userId = jwtUtils.ValidateToken(token);
        if (userId != null)
        {
            var user = accountFcd.GetById(userId);
            context.Items["User"] = user;
        }

        await _next(context);
    }
}
