using System.Net;
using MasterNet.Application.Core;
using MasterNet.Application.Precios.GetPrecios;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MasterNet.WebApi.Controllers;

[ApiController]
[Route("api/precios")]
public class PreciosController : ControllerBase
{
    private readonly ISender _sender;

    public PreciosController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<PagedList<PrecioResponse>>> PaginationPrecio
    (
        [FromQuery] GetPreciosRequest request,
        CancellationToken cancellationToken
    )
    {
        var query = new GetPreciosQuery.GetPreciosQueryRequest{
            PrecioRequest = request
        };
        var resultados = await _sender.Send(query,cancellationToken);
        return resultados.IsSuccess ? Ok(resultados.Value) : NotFound();
    }
}