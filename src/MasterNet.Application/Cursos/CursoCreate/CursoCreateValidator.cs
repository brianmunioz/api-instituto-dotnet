using FluentValidation;

namespace MasterNet.Application.Cursos.CursoCreate;

public class CursoCreateValidation:AbstractValidator<CursoCreateRequest>
{
    public CursoCreateValidation()
    {
        RuleFor(x=>x.Titulo).NotEmpty().WithMessage("Título no debe estar vacío");
        RuleFor(x=>x.Descripcion).NotEmpty().WithMessage("Descripción no debe estar vacío");
    }
}