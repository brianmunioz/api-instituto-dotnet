using FluentValidation;
using MasterNet.Application.Core;
using MasterNet.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MasterNet.Application.Cursos.CursoDelete;
public class CursoDeleteCommand 
{
    public record CursoDeleteCommandRequest(Guid? CursoId) : IRequest<Result<Unit>>;
    internal class CursoDeleteCommandHandler
    : IRequestHandler<CursoDeleteCommandRequest, Result<Unit>>
    {
        private readonly MasterNetDbContext _context;

        public CursoDeleteCommandHandler(MasterNetDbContext context)
        {
            _context = context;
        }

        public async Task<Result<Unit>> Handle(
            CursoDeleteCommandRequest request,
            CancellationToken cancellationToken)
        {
            var curso = await _context.Cursos!
            .Include(x=>x.Instructores)
            .Include(x=>x.Photos)
            .Include(x=>x.Calificaciones)
            .Include(x=>x.Precios)
            .FirstOrDefaultAsync(x=>x.Id == request.CursoId);
            if(curso is null)
            {
                return Result<Unit>.Failure("No existe el curso");
            }
            _context.Cursos!.Remove(curso);
            var resultado = await _context.SaveChangesAsync(cancellationToken) > 0;
            return resultado
                            ? Result<Unit>.Success(Unit.Value)
                            : Result<Unit>.Failure("Error en la transacción");
        }
    }
    internal class CursoDeleteCommandRequestValidator
    : AbstractValidator<CursoDeleteCommandRequest>
    {
        public CursoDeleteCommandRequestValidator()
        {
            RuleFor(x=>x.CursoId).NotNull().WithMessage("No tiene curso ID");
        }
    }

}