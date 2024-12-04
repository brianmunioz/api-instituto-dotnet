using Bogus;
using MasterNet.Domain;
using MasterNet.Persistence;
using MasterNet.Persistence.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MasterNet.WebApi.Extensions;

public static class DataSeed
{
    public static async Task SeedDataAuthentication(
        this IApplicationBuilder app
    )
    {
        using var scope = app.ApplicationServices.CreateScope();
        var service = scope.ServiceProvider;
        var loggerFactory = service.GetRequiredService<ILoggerFactory>();
        var userManager = service.GetRequiredService<UserManager<AppUser>>();


        try
        {
            var context = service.GetRequiredService<MasterNetDbContext>();
            await context.Database.MigrateAsync();
            if (!userManager.Users.Any())
            {
                var userAdmin = new AppUser
                {
                    NombreCompleto = "Brian Muñoz",
                    UserName = "brianmunozdotnet",
                    Email = "brianmunozjob@gmail.com"
                };
                await userManager.CreateAsync(userAdmin, "Password123$");
                await userManager.AddToRoleAsync(userAdmin, CustomRoles.ADMIN);


                var userClient = new AppUser
                {
                    NombreCompleto = "Manu Ginobili",
                    UserName = "ginobili5",
                    Email = "ginobili520@gmail.com"
                };
                await userManager.CreateAsync(userClient, "Password123$");
                await userManager.AddToRoleAsync(userClient, CustomRoles.CLIENT);

            }

            var cursos = await context.Cursos!.Take(10).Skip(0).ToListAsync();
            if (!context.Set<CursoInstructor>().Any())
            {
                var instructores =
                await context.Instructores!.Take(10).Skip(0).ToListAsync();
                foreach (var curso in cursos)
                {
                    curso.Instructores = instructores;
                }


            }

            if (!context.Set<CursoPrecio>().Any())
            {
                var precios = await context.Precios!.ToListAsync();
                foreach (var curso in cursos)
                {
                    curso.Precios = precios;
                }
            }

            if (!context.Set<Calificacion>().Any())
            {
                foreach(var curso in cursos)
                {
                    var fakerCalificacion = new Faker<Calificacion>()
                    .RuleFor(z=>z.Id, _ => Guid.NewGuid())
                    .RuleFor(z=>z.Alumno,z=>z.Name.FullName())
                    .RuleFor(z=>z.Comentario,x=>x.Commerce.ProductDescription())
                    .RuleFor(x=>x.Puntaje,5)
                    .RuleFor(x=>x.CursoId, curso.Id);
                    var calificaciones = fakerCalificacion.Generate(10);
                    context.AddRange(calificaciones);
                }

            }
            await context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            var logger = loggerFactory.CreateLogger<MasterNetDbContext>();
            logger.LogError(e.Message);
        }
    }
}