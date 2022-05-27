using Kalendarz2.Domain.Common;
using Kalendarz2.Domain.Common.Models.User;

namespace Kalendarz2.Domain.Interfaces.Facades;

public interface IAccountFcd
{
    UserDTO RegisterUser(RegisterDTO registerDTO);
    UserDTO LoginUser(LoginDTO loginDTO);
    UserDTO UpdateUser(EditUserDTO user);
    UserAuthorizeDTO GetById(int? id);
    UserDTO UserVerification(int userId);
    Task<UserDTO> SendResetLinkAsync(EmailDTO resetEmail);
    UserDTO ResetPassword(ResetPasswordDTO resetPassword);
}
