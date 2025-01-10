using System.Net;
using MasterNet.Application.Accounts;
using MasterNet.Application.Accounts.Login;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MasterNet.WebApi.Controllers;
[Route("api/account")]
public class AccountController : ControllerBase
{
    private readonly ISender _sender;

    public AccountController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost("login")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<Profile>> Login(
        [FromBody] LoginRequest request,
        CancellationToken cancellationToken
    )
    {
        var command = new LoginCommand.LoginCommandRequest(request);
        var resultado = await _sender.Send(command,cancellationToken);
        return resultado.IsSuccess ? Ok(resultado.Value) : Unauthorized();

    }
}