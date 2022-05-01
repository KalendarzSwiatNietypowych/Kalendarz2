using Kalendarz2.Domain.Common;

namespace Kalendarz2.Domain.Interfaces.Facades;

public interface IAccountFcd
{
    UserDTO RegisterUser(RegisterDTO registerDTO);
    UserDTO LoginUser(LoginDTO loginDTO);
    UserDTO UpdateUser(EditUserDTO user);
    UserAuthorizeDTO GetById(int? id);
    UserDTO UserVerification(int userId);
}
