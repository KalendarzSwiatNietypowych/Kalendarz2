using System.ComponentModel.DataAnnotations;

namespace Falco.UI.ASP.Entities;

public class Reminder
{
    public int Id { get; set; }
    public Event Event { get; set; }
    public Holiday Holiday { get; set; }
    public int AuthorId { get; set; }
    public DateTime RemindMe { get; set; }
}