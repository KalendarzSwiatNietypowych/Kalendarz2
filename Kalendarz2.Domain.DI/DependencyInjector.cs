using Kalendarz2.Domain.Common.Models.User;
using Kalendarz2.Domain.Facades;
using Kalendarz2.Domain.Interfaces.Facades;
using Kalendarz2.Domain.Interfaces.Infrastucture;
using Kalendarz2.Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Kalendarz2.Domain.Common.Utils;
using Kalendarz2.Infrastructure.EntityFramework.Mapper;
using Kalendarz2.Infrastructure.EntityFramework.Services;

namespace Kalendarz2.Domain.DI;

public static class DependencyInjector
{
    public static void AddDependency(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        serviceCollection.AddDbContext<CalendarDbContext>(x => x.UseSqlServer(connectionString));
        serviceCollection.AddScoped<IAccountFcd, AccountFcd>();
        serviceCollection.AddScoped<IAccountSrv, AccountSrv>();
        serviceCollection.AddScoped<IEventFcd, EventFcd>();
        serviceCollection.AddScoped<IEventSrv, EventSrv>();
        serviceCollection.AddScoped<IHolidayFcd, HolidayFcd>();
        serviceCollection.AddScoped<IHolidaySrv, HolidaySrv>();
        serviceCollection.AddScoped<EventMapper>();
        serviceCollection.AddScoped<IJwtUtils, JwtUtils>();


        //serviceCollection.AddAuthentication(options =>
        //{
        //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        //})
        //    .AddJwtBearer(o =>
        //    {
        //        o.RequireHttpsMetadata = false;
        //        o.SaveToken = false;
        //        o.TokenValidationParameters = new TokenValidationParameters
        //        {
        //            ValidateIssuerSigningKey = true,
        //            ValidateIssuer = true,
        //            ValidateAudience = true,
        //            ValidateLifetime = true,
        //            ClockSkew = TimeSpan.Zero,
        //            ValidIssuer = configuration["JSONWebTokensSettings:Issuer"],
        //            ValidAudience = configuration["JSONWebTokensSettings:Audience"],
        //            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JSONWebTokensSettings:Key"]))
        //        };

        //        o.Events = new JwtBearerEvents()
        //        {
        //            OnAuthenticationFailed = c =>
        //            {
        //                c.NoResult();
        //                c.Response.StatusCode = 500;
        //                c.Response.ContentType = "text/plain";
        //                return c.Response.WriteAsync(c.Exception.ToString());
        //            },
        //            OnChallenge = context =>
        //            {
        //                context.HandleResponse();
        //                context.Response.StatusCode = 401;
        //                context.Response.ContentType = "application/json";
        //                var result = JsonConvert.SerializeObject("401 Not authorized");
        //                return context.Response.WriteAsync(result);
        //            },
        //            OnForbidden = context =>
        //            {
        //                context.Response.StatusCode = 403;
        //                context.Response.ContentType = "application/json";
        //                var result = JsonConvert.SerializeObject("403 Not authorized");
        //                return context.Response.WriteAsync(result);
        //            },
        //        };
        //    });

        var authenticationSettings = new AuthenticationSettings();

        configuration.GetSection("Authentication").Bind(authenticationSettings);

        serviceCollection.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = "Bearer";
            options.DefaultScheme = "Bearer";
            options.DefaultChallengeScheme = "Bearer";
        }).AddJwtBearer(cfg =>
        {
            cfg.RequireHttpsMetadata = false;
            cfg.SaveToken = true;
            cfg.TokenValidationParameters = new TokenValidationParameters
            {
                ValidIssuer = authenticationSettings.JwtIssuer,
                ValidAudience = authenticationSettings.JwtIssuer,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authenticationSettings.JwtKey))
            };
        });

        serviceCollection.AddSingleton(authenticationSettings);
    }
}