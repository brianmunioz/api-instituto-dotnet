using MasterNet.Application.Interfaces;
using MasterNet.Persistence.Models;

namespace MasterNet.Infrastructure.Security;

public class TokenService : ITokenService
{
    public Task<string> CreateToken(AppUser user)
    {
        throw new NotImplementedException();
    }
}