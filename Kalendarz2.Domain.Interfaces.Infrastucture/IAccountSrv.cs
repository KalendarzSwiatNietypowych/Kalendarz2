﻿using Kalendarz2.Domain.Common;
using Kalendarz2.Domain.Common.Models.Event;

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
}
