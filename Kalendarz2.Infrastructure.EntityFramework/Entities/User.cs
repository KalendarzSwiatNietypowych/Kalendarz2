namespace Kalendarz2.Infrastructure.EntityFramework;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int RoleId { get; set; }
    public string Token { get; set; }
    public ICollection<Reminder> Reminders { get; set; }
    public ICollection<Participation> Participations { get; set; }
}