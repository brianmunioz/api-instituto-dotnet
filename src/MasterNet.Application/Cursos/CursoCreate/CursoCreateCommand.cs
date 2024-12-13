using FluentValidation;
using MasterNet.Application.Core;
using MasterNet.Domain;
using MasterNet.Persistence;
using MediatR;

namespace MasterNet.Application.Cursos.CursoCreate;

public class CursoCreateCommand
{
    public record CursosCreateCommandRequest(CursoCreateRequest cursoCreateRequest) : IRequest<Result<Guid>>;
    internal class CursoCreateCommandHandler
    : IRequestHandler<CursosCreateCommandRequest, Result<Guid>>
    {
        private readonly MasterNetDbContext _context;

        public CursoCreateCommandHandler(MasterNetDbContext context){
            _context = context;
        }
        public async Task<Result<Guid>> Handle(
        CursosCreateCommandRequest request,
        CancellationToken cancellationToken
        )
        {
            var curso = new Curso{
                Id = Guid.NewGuid(),
                Titulo = request.cursoCreateRequest.Titulo,
                Descripcion = request.cursoCreateRequest.Descripcion,
                FechaPublicacion = request.cursoCreateRequest.FechaPublicacion
            };
            _context.Add(curso);
            var resultado = await _context.SaveChangesAsync() > 0;
            return resultado ? 
            Result<Guid>.Success(curso.Id)
            :
            Result<Guid>.Failure("No se pudo insertar el grupo");

        }
    }

    public class CursosCreateRequestValidator
    : AbstractValidator<CursosCreateCommandRequest>
    {
        //En esta clase se inyecta las validaciones hechas en cursocreatevalidation
        public CursosCreateRequestValidator()
        {
            RuleFor(x=>x.cursoCreateRequest).SetValidator(new CursoCreateValidation());
        }
    }

}