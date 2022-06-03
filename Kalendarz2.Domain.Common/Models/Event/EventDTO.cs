using Kalendarz2.Domain.Common.Models.Event;

namespace Kalendarz2.Domain.Common;

public class EventDTO
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public ICollection<ParticipantDTO> Participants { get; set; }
    public DateTime StartEvent { get; set; }
    public DateTime EndEvent { get; set; }
    public string Color { get; set; }
    public bool IsRecurring { get; set; }
    public bool IsDeleted { get; set; }
}
