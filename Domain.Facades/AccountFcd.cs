using Kalendarz2.Domain.Common;
using Kalendarz2.Domain.Interfaces.Facades;

namespace Kalendarz2.Domain.Facades;

public class AccountFcd : IAccountFcd
{
    public UserAuthorizeDTO GetById(int? id)
    {
        throw new NotImplementedException();
    }

    public UserDTO LoginUser(LoginDTO loginDTO)
    {
        throw new NotImplementedException();
    }

    public UserDTO RegisterUser(RegisterDTO registerDTO)
    {
        throw new NotImplementedException();
    }

    public UserDTO UpdateUser(EditUserDTO user)
    {
        throw new NotImplementedException();
    }
}
