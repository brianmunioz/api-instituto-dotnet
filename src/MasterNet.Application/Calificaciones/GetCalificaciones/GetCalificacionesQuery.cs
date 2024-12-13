namespace MasterNet.Application.Calificaciones.GetCalificaciones;

public record CalificacionResponse
(
    string Alumno,
    int Puntaje,
    string Comentario,
    string NombreCurso
);
