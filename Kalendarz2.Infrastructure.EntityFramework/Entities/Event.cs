namespace Kalendarz2.Infrastructure.EntityFramework;

public class Event
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public string Title { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    public ICollection<Participation> Participants { get; set; }
    public DateTime StartEvent { get; set; }
    public DateTime EndEvent { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsRecurring { get; set; }
    public int Color { get; set; } //color stored as hex number
}