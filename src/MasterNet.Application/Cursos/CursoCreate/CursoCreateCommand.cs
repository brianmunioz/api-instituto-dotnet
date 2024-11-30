using MasterNet.Domain;
using MasterNet.Persistence;
using MediatR;

namespace MasterNet.Application.Cursos.CursoCreate;

public class CursoCreateCommand
{
    public record CursosCreateCommandRequest(CursoCreateRequest cursoCreateRequest) : IRequest<Guid>;
    internal class CursoCreateCommandHandler
    : IRequestHandler<CursosCreateCommandRequest, Guid>
    {
        private readonly MasterNetDbContext _context;

        public CursoCreateCommandHandler(MasterNetDbContext context){
            _context = context;
        }
        public async Task<Guid> Handle(
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
            await _context.SaveChangesAsync();
            return curso.Id;

        }
    }

}