using System;

namespace Kalendarz2.Domain.Common;

public class NewEventDTO
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public ICollection<string> ParticipantsEmails { get; set; }
    public DateTime StartEvent { get; set; }
    public DateTime EndEvent { get; set; }
    public int ColorR { get; set; }
    public int ColorG { get; set; }
    public int ColorB { get; set; }
}

