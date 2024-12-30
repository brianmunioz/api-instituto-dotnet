using FluentValidation;
namespace MasterNet.Application.Cursos.CursoUpdate;

public class CursoUpdateValidator 
: AbstractValidator<CursoUpdateRequest> 
{
    public CursoUpdateValidator()
    {
        RuleFor(x=>x.Titulo).NotEmpty().WithMessage("El Titulo no debe estar vacío");
        RuleFor(x=>x.Descripcion).NotEmpty().WithMessage("La descripción no debe estar vacía");
        RuleFor(x=>x.FechaPublicacion).NotEmpty().WithMessage("La fecha de publicación no debe ser vacía");
    }
}