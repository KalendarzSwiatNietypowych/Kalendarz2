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
            FirstName = user.FirstName,
            LastName = user.LastName,
            Token = token
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
            RoleId = registerDTO.RoleId,
            isVerified = false
        };

        var emailToSend = new SendEmailDTO() { Email = registerDTO.Email };
        //EmailSenderAsync(emailToSend);
        newUser.isVerified = true;
        //poki co do testowania
        //nie jest wysyłany link do potwierdzania

        var hashedPassword = _passwordHasher.HashPassword(newUser, registerDTO.Password);
        newUser.PasswordHash = hashedPassword;

        _dbContext.Users.Add(newUser);
        _dbContext.SaveChanges();

        var userAuth = new UserAuthorizeDTO
        {
            Id = newUser.Id,
            Email = newUser.Email,
            FirstName = newUser.FirstName,
            LastName = newUser.LastName,
            PasswordHash = newUser.PasswordHash
        };

        var token = _jwtUtils.GenerateJWT(userAuth);
        return new UserDTO()
        {
            Id = newUser.Id,
            FirstName = newUser.FirstName,
            LastName = newUser.LastName,
            Token = token
        };
    }

    public UserDTO UpdateUser(EditUserDTO user)
    {
        var userdb = _dbContext.Users.Where(u => u.Id == user.Id).FirstOrDefault();
        if (userdb == null) throw new EditUserException();

        userdb.FirstName = user.FirstName;
        userdb.LastName = user.LastName;
        userdb.Email = user.Email;
        _dbContext.SaveChanges();

        return new UserDTO
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName
        };
    }

    public async Task<bool> EmailSenderAsync(SendEmailDTO email)
    {
        var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
        var client = new SendGridClient(apiKey);
        var user = _dbContext.Users.FirstOrDefault(u => u.Email == email.Email);

        var msg = new SendGridMessage()
        {
            From = new EmailAddress("kalendarz2@onet.pl", "Team Kalendarz 2"),
            Subject = "Verification Mail to Kalendarz2",
            PlainTextContent = $"Hello {user.FirstName} {user.LastName} \n\n " +
            $"We're really glad you registered to our webite. In order to verify your email play click in this not suspisiout link belowed:\n" +
            $"/api/Account/verify/{user.Id}"
        };
        msg.AddTo(new EmailAddress(user.Email, "Dear new user"));
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
            FirstName = user.FirstName,
            LastName = user.LastName
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
}
