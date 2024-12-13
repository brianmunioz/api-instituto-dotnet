using MasterNet.Application.Calificaciones.GetCalificaciones;
using MasterNet.Application.Core;
using MasterNet.Application.Instructores.GetInstructores;
using MasterNet.Application.Photos.GetPhoto;
using MasterNet.Application.Precios.GetPrecios;
using MediatR;

namespace MasterNet.Application.Cursos.GetCurso;

public class GetCursoQuery
{
    public record GetCursoQueryRequest
    : IRequest<Result<CursoResponse>>;
}

public record CursoResponse
(
    Guid Id,
    string Titulo,
    string Descripcion,
    DateTime? FechaPublicacion,
    List<InstructorResponse> Instructores,
    List<CalificacionResponse> Calificaciones,
    List<PrecioResponse> Precios,
    List<PhotoResponse> Photos

);