using System.ComponentModel.DataAnnotations;

namespace Kalendarz2.Domain.Common;

public class ResetPasswordDTO
{
    public string Email { get; set; }
    [Required][MinLength(6)] public string Password { get; set; }
}
