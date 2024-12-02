using MasterNet.Application;
using MasterNet.Persistence;

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

app.MapControllers();
app.Run();