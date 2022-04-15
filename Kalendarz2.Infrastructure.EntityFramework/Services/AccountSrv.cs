using Kalendarz2.Domain.Common;
using Kalendarz2.Domain.Common.Exceptions;
using Kalendarz2.Domain.Interfaces.Infrastucture;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Kalendarz2.Infrastructure.EntityFramework;

public class AccountSrv : IAccountSrv
{
    private readonly CalendarDbContext _dbContext;

    public AccountSrv(CalendarDbContext dbContext)
    {
        _dbContext = dbContext;
    }
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
        var emailInUse = _dbContext.Users.Any(u => u.Email == registerDTO.Email);
        //if (emailInUse) throw new EmailTakenException();
        var newUser = new User
        {
            Email = registerDTO.Email,
            FirstName = registerDTO.FirstName,
            LastName = registerDTO.LastName,
            RoleId = registerDTO.RoleId,
            PasswordHash = registerDTO.Password,
            isVerified = false
        };

        var emailToSend = new SendEmailDTO() { Email = registerDTO.Email };
        EmailSenderAsync(emailToSend);

        _dbContext.Users.Add(newUser);
        _dbContext.SaveChanges();

        return new UserDTO()
        {
            Id = newUser.Id,
            FirstName = newUser.FirstName,
            LastName = newUser.LastName,
            Email = newUser.Email
        };
    }

    public UserDTO UpdateUser(EditUserDTO user)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> EmailSenderAsync(SendEmailDTO mail)
    {
        var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
        var client = new SendGridClient(apiKey);
        var msg = new SendGridMessage()
        {
            From = new EmailAddress("kalendarz2@onet.pl", "Team Kalendarz 2"),
            Subject = "Verification Mail to Kalendarz2",
            PlainTextContent = "Hey you!"
        };
        msg.AddTo(new EmailAddress(mail.Email, "Drogi nowy użytkowniku"));
        var response = await client.SendEmailAsync(msg);

        return true;
    }
}
