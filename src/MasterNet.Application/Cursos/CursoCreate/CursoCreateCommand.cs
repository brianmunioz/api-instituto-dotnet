using FluentValidation;
using MasterNet.Application.Core;
using MasterNet.Application.Interfaces;
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
        private readonly IPhotoService _photoService;

        public CursoCreateCommandHandler
        (
            MasterNetDbContext context,
            IPhotoService photoService
        )
        {
            _context = context;
            _photoService = photoService;
        }
        public async Task<Result<Guid>> Handle(
        CursosCreateCommandRequest request,
        CancellationToken cancellationToken
        )
        {
            var cursoId = Guid.NewGuid();
            var curso = new Curso{
                Id = cursoId,
                Titulo = request.cursoCreateRequest.Titulo,
                Descripcion = request.cursoCreateRequest.Descripcion,
                FechaPublicacion = request.cursoCreateRequest.FechaPublicacion
            };
            if(request.cursoCreateRequest.Foto is not null)
            {
             var photoUploadResult =  await  _photoService.AddPhoto(request.cursoCreateRequest.Foto);
             var photo = new Photo
             {
                Id = Guid.NewGuid(),
                PublicId = photoUploadResult.PublicId,
                Url = photoUploadResult.Url,
                CursoId = cursoId
             };
             curso.Photos = new List<Photo>{photo};

            }
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