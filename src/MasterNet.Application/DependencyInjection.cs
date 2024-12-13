using FluentValidation;
using FluentValidation.AspNetCore;
using MasterNet.Application.Cursos.CursoCreate;
using Microsoft.Extensions.DependencyInjection;

namespace MasterNet.Application;

public static class DependendyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services
    ){
        services.AddMediatR(configuration=>{
            configuration
            .RegisterServicesFromAssembly(typeof(DependendyInjection).Assembly);
        });
        services.AddFluentValidationAutoValidation();
        services.AddValidatorsFromAssemblyContaining<CursoCreateCommand>();
        return services;
    }
}