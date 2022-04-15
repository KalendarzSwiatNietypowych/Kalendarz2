using Kalendarz2.Domain.Common;
using Kalendarz2.Domain.Interfaces.Facades;
using Kalendarz2.Domain.Interfaces.Infrastucture;

namespace Kalendarz2.Domain.Facades;

public class AccountFcd : IAccountFcd
{
    private readonly IAccountSrv _accountSrv;

    public AccountFcd(IAccountSrv accountSrv)
    {
        _accountSrv = accountSrv;
    }
    public UserDTO RegisterUser(RegisterDTO registerDTO)
    {
        return _accountSrv.RegisterUser(registerDTO);
    }
    public UserAuthorizeDTO GetById(int? id)
    {
        throw new NotImplementedException();
    }

    public UserDTO LoginUser(LoginDTO loginDTO)
    {
        throw new NotImplementedException();
    }

    public UserDTO UpdateUser(EditUserDTO user)
    {
        throw new NotImplementedException();
    }
}
