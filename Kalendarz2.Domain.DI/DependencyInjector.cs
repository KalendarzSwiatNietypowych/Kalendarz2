using Kalendarz2.Domain.Facades;
using Kalendarz2.Domain.Interfaces.Facades;
using Kalendarz2.Domain.Interfaces.Infrastucture;
using Kalendarz2.Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Kalendarz2.Domain.DI;

public static class DependencyInjector
{
    public static void AddDependency(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        serviceCollection.AddDbContext<CalendarDbContext>(x => x.UseSqlServer(connectionString));
        serviceCollection.AddScoped<IAccountFcd, AccountFcd>();
        serviceCollection.AddScoped<IAccountSrv, AccountSrv>();
    }
}