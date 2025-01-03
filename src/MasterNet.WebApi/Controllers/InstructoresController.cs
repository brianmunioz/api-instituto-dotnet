using System.Net;
using MasterNet.Application.Instructores.GetInstructores;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MasterNet.WebApi.Controllers;

[ApiController]
[Route("api/instructores")]
public class InstructoresController : ControllerBase
{
    private readonly ISender _sender;

    public InstructoresController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<InstructorResponse>> PaginationInstructor
    (
        [FromQuery] GetInstructoresRequest request,
        CancellationToken cancellationToken
    )
    {
        var query = new GetInstructoresQuery.GetInstructoresQueryRequest{
            InstructorRequest = request
        };
        var resultados = await _sender.Send(query,cancellationToken);
        return resultados.IsSuccess ? Ok(resultados.Value) : NotFound();
    }
}