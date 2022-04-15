using Backend.Models.User;

namespace Backend.Interfaces.Services;

public interface IAccountSrv
{
    UserDTO RegisterUser(RegisterDTO registerDTO);
    UserDTO LoginUser(LoginDTO loginDTO);
    UserDTO UpdateUser(EditUserDTO user);
    UserAuthorizeDTO GetById(int? id);
}
