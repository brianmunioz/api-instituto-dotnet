using MasterNet.Application;
using MasterNet.Application.Interfaces;
using MasterNet.Infrastructure.Reports;
using MasterNet.Persistence;
using MasterNet.Persistence.Models;
using MasterNet.WebApi.Extensions;
using MasterNet.WebApi.Middleware;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApplication();
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddScoped(typeof(IReportService<>), typeof(ReportService<>)); //forma de implementar cuando son genericos, cada vez que el contenedor encuentre una dependencia de IReportService hace una instancia de ReportService
// builder.Services.AddScoped<IReportService, ReportService>(); forma normal de implementar (cuando no es generico)
builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddIdentityCore<AppUser>(opt=>{
    opt.Password.RequireNonAlphanumeric = false;
    opt.User.RequireUniqueEmail = true;
}).AddRoles<IdentityRole>().AddEntityFrameworkStores<MasterNetDbContext>();

builder.Services.AddMediatR(configuration=>{configuration.RegisterServicesFromAssembly(typeof(Program).Assembly);});

var app = builder.Build();
app.UseMiddleware<ExceptionMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
await app.SeedDataAuthentication();

app.MapControllers();
app.Run();