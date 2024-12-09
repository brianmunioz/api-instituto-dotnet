using System.Net;
using System.Text.Json;
using MasterNet.Application.Core;

namespace MasterNet.WebApi.Middleware;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionMiddleware> _logger;
    private readonly IHostEnvironment _env;

    public ExceptionMiddleware(
        IHostEnvironment env,
        ILogger<ExceptionMiddleware> logger, 
        RequestDelegate next
    )
    {
        _env = env;
        _logger = logger;
        _next = next; 
    }


public async Task InvokeAsync(HttpContext context){
    try
    {
        await _next(context);
    }
    catch(Exception ex)
    {
        _logger.LogError(ex, ex.Message);
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        var response = _env.IsDevelopment()
        ? new AppException(ex.Message,context.Response.StatusCode,ex.StackTrace?.ToString())
        : new AppException("Internal Server Error",context.Response.StatusCode);
        var options = new JsonSerializerOptions{
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };
        var json = JsonSerializer.Serialize(response,options);
        await context.Response.WriteAsync(json);
        
    }

}


}