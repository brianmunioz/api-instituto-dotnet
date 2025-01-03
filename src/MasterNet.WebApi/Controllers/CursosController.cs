using System.Net;
using MasterNet.Application.Core;
using MasterNet.Application.Cursos.CursoCreate;
using MasterNet.Application.Cursos.CursoDelete;
using MasterNet.Application.Cursos.CursoReporteExcel;
using MasterNet.Application.Cursos.CursoUpdate;
using MasterNet.Application.Cursos.GetCurso;
using MasterNet.Application.Cursos.GetCursos;
using MasterNet.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static MasterNet.Application.Cursos.CursoCreate.CursoCreateCommand;
using static MasterNet.Application.Cursos.GetCurso.GetCursoQuery;

namespace MasterNet.WebApi.Controllers;
[ApiController]
[Route("api/cursos")]
public class CursosController : ControllerBase
{
    private readonly ISender _sender;
    public CursosController(ISender sender)
    {
        _sender = sender;
    }
    [HttpGet]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<PagedList<CursoResponse>>> PaginationCursos
    (
        [FromQuery] GetCursosRequest request,
        CancellationToken cancellationToken
    )
    {
        var query = new GetCursosQuery.GetCursosQueryRequest{CursosRequest = request};
        var resultado = await _sender.Send(query,cancellationToken);
        return resultado.IsSuccess ? Ok(resultado.Value) : NotFound();
    }
    [HttpGet("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<CursoResponse>> CursoGet(
        Guid id,
        CancellationToken cancellationToken
        )
    {
        var query = new GetCursoQueryRequest { Id = id };
        var resultado = await _sender.Send(query, cancellationToken);
        return resultado.IsSuccess ? Ok(resultado.Value) : BadRequest();
    }

    [HttpPost]
    public async Task<ActionResult<Result<Guid>>> CursoCreate(
       [FromForm] CursoCreateRequest request,
       CancellationToken cancellationToken
    )
    {
        var command = new CursosCreateCommandRequest(request);
        var resultado =  await _sender.Send(command, cancellationToken);
        return resultado.IsSuccess ? Ok(resultado.Value) : BadRequest("No se pudo crear el curso");

    }

    [HttpPut]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<Result<Guid>>> CursoUpdate(
        [FromBody] CursoUpdateRequest request,
        Guid id,
        CancellationToken cancellationToken
    )
    {
        var command = new CursoUpdateCommand.CursoUpdateCommandRequest(request,id);
        var resultado = await _sender.Send(command,cancellationToken);
        return resultado.IsSuccess ? Ok(resultado.Value) : BadRequest("No se pudo actualizar el curso");

    }
    [HttpDelete]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<Unit>> CursoDelete(
        Guid cursoId,
        CancellationToken cancellationToken
    )
    {
        var command = new CursoDeleteCommand.CursoDeleteCommandRequest(cursoId);
        var resultado = await _sender.Send(command,cancellationToken);    
        return resultado.IsSuccess ? Ok() : BadRequest("No se pudo eliminar el curso");
    }

    [HttpGet("reporte")]
    public async Task<IActionResult> ReportCsv(CancellationToken cancellationToken)
    {
        var query = new CursoReporteExcelQuery.CursoReporteExcelQueryRequest();
        var resultado = await _sender.Send(query, cancellationToken);
        byte[] excelBytes = resultado.ToArray();
        return File(excelBytes, "text/csv", "cursos.csv");
    }
}