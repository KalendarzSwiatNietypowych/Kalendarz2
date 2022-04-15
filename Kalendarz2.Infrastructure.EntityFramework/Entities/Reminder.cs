namespace Kalendarz2.Infrastructure.EntityFramework;

public class Reminder
{
    public int Id { get; set; }
    public Event Event { get; set; }
    public Holiday Holiday { get; set; }
    public int AuthorId { get; set; }
    public DateTime RemindMe { get; set; }
}