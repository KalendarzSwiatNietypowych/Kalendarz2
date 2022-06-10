using Kalendarz2.Domain.Common;
using Kalendarz2.Domain.Common.Models.Event;
using Kalendarz2.Domain.Common.Models.User;

namespace Kalendarz2.Domain.Interfaces.Infrastucture;

public interface IAccountSrv
{
    UserDTO RegisterUser(RegisterDTO registerDTO);
    UserDTO LoginUser(LoginDTO loginDTO);
    UserDTO UpdateUser(EditUserDTO user);
    UserAuthorizeDTO GetById(int? id);
    Task<bool> EmailSenderAsync(SendEmailDTO mail);
    UserDTO UserVerification(int userId);
    ParticipantDTO GetParticipantByMail(string mail);
    Task<UserDTO> SendResetLinkAsync(EmailDTO resetEmail);
    UserDTO ResetPassword(ResetPasswordDTO resetPassword);
    UserDTO DeleteAccount(DeleteUserDTO delete);
}
