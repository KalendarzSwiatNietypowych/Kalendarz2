using System.ComponentModel.DataAnnotations;

namespace Kalendarz2.Domain.Common;

public class EditUserDTO
{
    [Required] public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Color { get; set; }
    public bool IsDarkmode { get; set; }
}
