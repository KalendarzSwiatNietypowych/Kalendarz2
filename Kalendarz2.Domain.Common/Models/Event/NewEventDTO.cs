using System;
using System.ComponentModel.DataAnnotations;

namespace Kalendarz2.Domain.Common;

public class NewEventDTO
{
    [Required]
    public int AuthorId { get; set; }
    [Required]
    public string Title { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public ICollection<string> ParticipantsEmails { get; set; }
    [Required]
    public DateTime StartEvent { get; set; }
    public DateTime EndEvent { get; set; }
    [Required] 
    public int Color { get; set; }
    public bool IsRecurring { get; set; } = false;
}

