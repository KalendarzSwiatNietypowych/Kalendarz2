using Backend.Models.User;

namespace Backend.Interfaces.Facades;

public interface IAccountFcd
{
    UserDTO RegisterUser(RegisterDTO registerDTO);
    UserDTO LoginUser(LoginDTO loginDTO);
    UserDTO UpdateUser(EditUserDTO user);
    UserAuthorizeDTO GetById(int? id);
}
