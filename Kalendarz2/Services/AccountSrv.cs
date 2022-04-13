using Backend.Interfaces.Services;
using Backend.Models.User;

namespace Backend.Services;

public class AccountSrv : IAccountSrv
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
