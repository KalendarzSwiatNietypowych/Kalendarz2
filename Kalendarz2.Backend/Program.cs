using Kalendarz2.Domain.Common.Models.User;
using Kalendarz2.Domain.DI;
using Kalendarz2.Infrastructure.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDependency(builder.Configuration);
builder.Services.AddDbContext<CalendarDbContext>(x => x.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=CalendarDb;Trusted_Connection=True;"));
builder.Services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        b =>
        {
            b.WithOrigins("http://localhost:3000/").AllowAnyHeader().AllowAnyMethod().SetIsOriginAllowed(_ => true)
                .AllowCredentials();
        });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMvc();

builder.Services.Configure<JSONWebTokensSettings>(builder.Configuration.GetSection("JSONWebTokensSettings"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.UseCors();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();