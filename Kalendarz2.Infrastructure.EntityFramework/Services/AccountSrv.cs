using Kalendarz2.Domain.Common;
using Kalendarz2.Domain.Common.Exceptions;
using Kalendarz2.Domain.Common.Models.Event;
using Kalendarz2.Domain.Common.Models.User;
using Kalendarz2.Domain.Common.Utils;
using Kalendarz2.Domain.Interfaces.Infrastucture;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Kalendarz2.Infrastructure.EntityFramework;

public class AccountSrv : IAccountSrv
{
    private readonly CalendarDbContext _dbContext;
    private readonly IPasswordHasher<User> _passwordHasher;
    private readonly IJwtUtils _jwtUtils;

    public AccountSrv(CalendarDbContext dbContext, IPasswordHasher<User> passwordHasher, IJwtUtils jwtUtils)
    {
        _dbContext = dbContext;
        _passwordHasher = passwordHasher;
        _jwtUtils = jwtUtils;

    }
    public UserAuthorizeDTO GetById(int? id)
    {
        var user = _dbContext.Users.FirstOrDefault(u => u.Id == id);
        var userAuthorize = new UserAuthorizeDTO()
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            PasswordHash = user.PasswordHash
        };

        return userAuthorize;
    }

    public UserDTO LoginUser(LoginDTO loginDTO)
    {
        var user = _dbContext.Users.FirstOrDefault(u => u.Email == loginDTO.Email);
        if (user == null) throw new LoginException();
        var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, loginDTO.Password);
        if (result == PasswordVerificationResult.Failed) throw new LoginException();
        var userAuth = new UserAuthorizeDTO
        {
            Id = user.Id,
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            PasswordHash = user.PasswordHash
        };

        var token = _jwtUtils.GenerateJWT(userAuth);
        return new UserDTO
        {
            Id = user.Id,
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Token = token,
            Color = user.Color,
            IsDarkmode = user.IsDarkmode
        };
    }

    public UserDTO RegisterUser(RegisterDTO registerDTO)
    {
        var emailInUse = _dbContext.Users.Any(u => u.Email == registerDTO.Email);
        if (emailInUse) throw new EmailTakenException();
        var newUser = new User
        {
            Email = registerDTO.Email,
            FirstName = registerDTO.FirstName,
            LastName = registerDTO.LastName,
            PasswordHash = "",
            isVerified = false,
            IsDarkmode = true,
            Color = "#2BC598"
        };

        _dbContext.Users.Add(newUser);
        _dbContext.SaveChanges();

        var newUserDTO = new UserDTO
        {
            Id = _dbContext.Users.FirstOrDefault(u => u.Email == registerDTO.Email).Id,
            FirstName = newUser.FirstName,
            LastName = newUser.LastName,
            Email = newUser.Email
        };

        var emailToSend = new SendEmailDTO() { user = newUserDTO, Email = registerDTO.Email };
        EmailSenderAsync(emailToSend);

        var hashedPassword = _passwordHasher.HashPassword(newUser, registerDTO.Password);
        newUser.PasswordHash = hashedPassword;

        _dbContext.SaveChanges();

        var userAuth = new UserAuthorizeDTO
        {
            Id = newUser.Id,
            Email = newUser.Email,
            FirstName = newUser.FirstName,
            LastName = newUser.LastName,
            PasswordHash = newUser.PasswordHash
        };

        return new UserDTO()
        {
            Id = newUser.Id,
            Email = newUser.Email,
            FirstName = newUser.FirstName,
            LastName = newUser.LastName,
            Token = null,
            Color = "#2BC598",
            IsDarkmode = true
        };
    }

    public UserDTO UpdateUser(EditUserDTO user)
    {
        var userdb = _dbContext.Users.Where(u => u.Id == user.UserId).FirstOrDefault();
        var isEmailTaken = _dbContext.Users.FirstOrDefault(u => u.Email == user.Email);
        if (isEmailTaken == userdb) isEmailTaken = null;

        if (userdb == null || isEmailTaken != null) throw new EditUserException();

        userdb.FirstName = user.FirstName;
        userdb.LastName = user.LastName;
        userdb.Email = user.Email;
        userdb.Color = user.Color;
        userdb.IsDarkmode = user.IsDarkmode;
        _dbContext.Users.Update(userdb);
        _dbContext.SaveChanges();

        return new UserDTO
        {
            Id = user.UserId,
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Color = user.Color,
            IsDarkmode = user.IsDarkmode
        };
    }

    public async Task<bool> EmailSenderAsync(SendEmailDTO email)
    {
        var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
        var client = new SendGridClient(apiKey);

        var msg = new SendGridMessage()
        {
            From = new EmailAddress("kalendarz2@onet.pl", "Team Kalendarz 2"),
            Subject = "Verification Mail to Kalendarz2",
            PlainTextContent = $"Hello {email.user.FirstName} {email.user.LastName} \n\n " +
            $"We're really glad you registered to our webite. In order to verify your email play click in this not suspicious link belowed:\n\n" +
            $"/api/Account/verify/{email.user.Id}"
        };
        //zmienić ścieżkę
        msg.AddTo(new EmailAddress(email.user.Email, "Dear new user"));
        var response = await client.SendEmailAsync(msg);

        return true;
    }

    public UserDTO UserVerification(int userId)
    {
        var user = _dbContext.Users.FirstOrDefault(u => u.Id == userId);
        user.isVerified = true;
        _dbContext.SaveChanges();

        return new UserDTO()
        {
            Id = userId,
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Color = user.Color,
            IsDarkmode = user.IsDarkmode
        };
    }

    public ParticipantDTO GetParticipantByMail(string mail)
    {
        var user = _dbContext.Users.FirstOrDefault(u => u.Email == mail);

        return new ParticipantDTO()
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName
        };
    }

    public async Task<UserDTO> SendResetLinkAsync(EmailDTO resetEmail)
    {
        var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
        var client = new SendGridClient(apiKey);
        var user = _dbContext.Users.FirstOrDefault(u => u.Email == resetEmail.email);

        var msg = new SendGridMessage()
        {
            From = new EmailAddress("kalendarz2@onet.pl", "Team Kalendarz 2"),
            Subject = "Restar password to Kalendarz2",
            PlainTextContent = $"Hello {user.FirstName} {user.LastName} \n\n " +
            $"We're really sorry you forgot password to our site. Don't worry here is link to reset your password in order to use our website:\n\n" +
            $"localhost:blablabla/api/Account/resetPassword/{user.Id}"
            //zmienić ścieżkę
        };
        msg.AddTo(new EmailAddress(user.Email, "Dear user"));
        var response = await client.SendEmailAsync(msg);

        return new UserDTO
        {
            Id = user.Id,
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Color = user.Color,
            IsDarkmode = user.IsDarkmode
        };
    }

    public UserDTO ResetPassword(ResetPasswordDTO resetPassword)
    {
        var user = _dbContext.Users.FirstOrDefault(u => u.Id == resetPassword.UserId);

        var hashedPassword = _passwordHasher.HashPassword(user, resetPassword.Password);
        user.PasswordHash = hashedPassword;

        _dbContext.Update(user);
        _dbContext.SaveChanges();

        return new UserDTO
        {
            Id = user.Id,
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Color = user.Color,
            IsDarkmode = user.IsDarkmode
        };
    }

    public UserDTO DeleteAccount(DeleteUserDTO delete)
    {
        var toDelete = _dbContext.Users.FirstOrDefault(u => u.Id == delete.UserId);
        var result = _passwordHasher.VerifyHashedPassword(toDelete, toDelete.PasswordHash, delete.Password);
        if (result == PasswordVerificationResult.Failed) throw new PasswordException();

        _dbContext.Users.Remove(toDelete);
        _dbContext.SaveChanges();

        return new UserDTO
        {
            Id = toDelete.Id,
            Email = toDelete.Email,
            FirstName = toDelete.FirstName,
            LastName = toDelete.LastName,
            Token = null,
            Color = toDelete.Color,
            IsDarkmode = toDelete.IsDarkmode
        };
    }

    public UserDTO ChangePassword(ChangePasswordDTO changePassword)
    {
        var user = _dbContext.Users.FirstOrDefault(u => u.Id == changePassword.UserId);
        var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, changePassword.OldPassword);
        if (result == PasswordVerificationResult.Failed) throw new PasswordException();

        var hashedPassword = _passwordHasher.HashPassword(user, changePassword.Password);
        user.PasswordHash = hashedPassword;

        _dbContext.SaveChanges();
        return new UserDTO
        {
            Id = user.Id,
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Color = user.Color,
            IsDarkmode = user.IsDarkmode
        };
    }
}
