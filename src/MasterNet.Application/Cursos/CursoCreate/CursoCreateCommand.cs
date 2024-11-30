using MediatR;

namespace MasterNet.Application.Cursos.CursoCreate;

public class CursoCreateCommand
{
    public record CursosCreateCommandRequest(CursoCreateRequest cursoCreateRequest) : IRequest<Guid>;

}