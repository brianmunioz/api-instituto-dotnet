using MasterNet.Application.Core;
using MasterNet.Application.Cursos.CursoCreate;
using MasterNet.Application.Cursos.CursoReporteExcel;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static MasterNet.Application.Cursos.CursoCreate.CursoCreateCommand;

namespace MasterNet.WebApi.Controllers;
[ApiController]
[Route("api/cursos")]
public class CursosController:ControllerBase
{
private readonly ISender _sender;
public CursosController(ISender sender){
    _sender = sender;
}
[HttpPost("create")]
public async Task<ActionResult<Result<Guid>>> CursoCreate(
   [FromForm] CursoCreateRequest request,
   CancellationToken cancellationToken 
) {
var command = new CursosCreateCommandRequest(request);
return await _sender.Send(command,cancellationToken);

}

[HttpGet("reporte")]
public async Task<IActionResult> ReportCsv(CancellationToken cancellationToken)
{
    var query = new CursoReporteExcelQuery.CursoReporteExcelQueryRequest();
    var resultado = await _sender.Send(query,cancellationToken);
    byte[] excelBytes = resultado.ToArray();
    return File(excelBytes,"text/csv","cursos.csv");
}
}