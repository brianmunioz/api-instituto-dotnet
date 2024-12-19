namespace MasterNet.Application.Precios.GetPrecios;

using System.Linq.Expressions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MasterNet.Application.Core;
using MasterNet.Domain;
using MasterNet.Persistence;
using MediatR;


public class GetPreciosQuery
{
    public record GetPreciosQueryRequest 
    : IRequest<Result<PagedList<PrecioResponse>>>
    {
        public GetPreciosRequest? PrecioRequest {get;set;}
    }

    internal class GetPreciosQueryHandler :
    IRequestHandler<GetPreciosQueryRequest, Result<PagedList<PrecioResponse>>>
    {
        private readonly MasterNetDbContext _context;
        private readonly IMapper _mapper;
        public GetPreciosQueryHandler(MasterNetDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Result<PagedList<PrecioResponse>>> Handle
        (
            GetPreciosQueryRequest request,
            CancellationToken cancellationToken
        )
        {
            IQueryable<Precio> queryable = _context.Precios!;
            var predicate = ExpressionBuilder.New<Precio>();
            if(!string.IsNullOrEmpty(request.PrecioRequest!.Nombre))
            {
                predicate = predicate
                            .And(y=>y.Nombre!.Contains(request.PrecioRequest!.Nombre));
            }
            if(!string.IsNullOrEmpty(request.PrecioRequest!.OrderBy))
            {
                Expression<Func<Precio, object>> ? orderSelector = 
                request.PrecioRequest.OrderBy.ToLower() switch
                {
                    "nombre" => e=>e.Nombre!,
                    "precio"=> e=>e.PrecioActual!,
                    _=>e=>e.Nombre!
                };
                 bool orderBy = request.PrecioRequest.OrderByAsc.HasValue 
                        ? request.PrecioRequest.OrderByAsc.Value
                        : true;
                queryable = orderBy 
                            ? queryable.OrderBy(orderSelector)
                            :queryable.OrderByDescending(orderSelector);
            }
           queryable = queryable.Where(predicate);
           var preciosQuery = queryable
                                .ProjectTo<PrecioResponse>(_mapper.ConfigurationProvider)
                                .AsQueryable();
            var pagination = await PagedList<PrecioResponse>
                            .CreateAsync
                            (
                                preciosQuery,
                                request.PrecioRequest.PageNumber,
                                request.PrecioRequest.PageSize
                            );
            


            return Result<PagedList<PrecioResponse>>.Success(pagination);
        }
    }
}

public record PrecioResponse
(
    Guid? Id,
    string? Nombre,
    decimal? PrecioPromocion,
    decimal? PrecioActual
)
{
    public PrecioResponse():this(null,null,null,null){}
};