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
        registerDTO.Email.ToLower();
        return _accountSrv.RegisterUser(registerDTO);
    }
    public UserAuthorizeDTO GetById(int? id)
    {
        return _accountSrv.GetById(id);
    }

    public UserDTO LoginUser(LoginDTO loginDTO)
    {
        loginDTO.Email.ToLower();
        return _accountSrv.LoginUser(loginDTO);
    }

    public UserDTO UpdateUser(EditUserDTO user)
    {
        return _accountSrv.UpdateUser(user);
    }

    public UserDTO UserVerification(int userId)
    {
        return _accountSrv.UserVerification(userId);
    }
}
