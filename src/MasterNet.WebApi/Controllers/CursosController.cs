using MasterNet.Application.Core;
using MasterNet.Application.Cursos.CursoCreate;
using MasterNet.Application.Cursos.CursoReporteExcel;
using MasterNet.Application.Cursos.GetCursos;
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
    public async Task<ActionResult> PaginationCursos
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
    public async Task<IActionResult> CursoGet(
        Guid id,
        CancellationToken cancellationToken
        )
    {
        var query = new GetCursoQueryRequest { Id = id };
        var resultado = await _sender.Send(query, cancellationToken);
        return resultado.IsSuccess ? Ok(resultado.Value) : BadRequest();
    }

    [HttpPost("create")]
    public async Task<ActionResult<Result<Guid>>> CursoCreate(
       [FromForm] CursoCreateRequest request,
       CancellationToken cancellationToken
    )
    {
        var command = new CursosCreateCommandRequest(request);
        return await _sender.Send(command, cancellationToken);

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