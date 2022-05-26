using System.ComponentModel.DataAnnotations;

namespace Kalendarz2.Domain.Common.Models.Event;

public class EditEventDTO
{
    [Required]
    public int AuthorId { get; set; }
    [Required]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public ICollection<string> ParticipantsEmails { get; set; }
    [Required]
    public DateTime StartEvent { get; set; }
    public DateTime EndEvent { get; set; }
    [Required]
    public string Color { get; set; }
    public bool IsRecurring { get; set; }
    public bool IsDeleted { get; set; }
}
