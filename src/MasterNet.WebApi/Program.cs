using MasterNet.Application;
using MasterNet.Persistence;
using MasterNet.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApplication();
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(configuration=>{configuration.RegisterServicesFromAssembly(typeof(Program).Assembly);});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
await app.SeedDataAuthentication();

app.MapControllers();
app.Run();