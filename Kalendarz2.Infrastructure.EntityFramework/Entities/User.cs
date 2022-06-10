namespace Kalendarz2.Infrastructure.EntityFramework;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool isVerified { get; set; } = false;
    public int RoleId { get; set; }
    public Role Role { get; set; }
    public ICollection<Reminder> Reminders { get; set; }
    public ICollection<Participation> Participations { get; set; }
    public string Color { get; set; }
    public bool IsDarkmode { get; set; }
}