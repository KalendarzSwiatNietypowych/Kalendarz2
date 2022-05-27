using System.ComponentModel.DataAnnotations;

namespace Kalendarz2.Domain.Common;

public class ResetPasswordDTO
{
    //[Required] 
    public int UserId { get; set; }
    [Required][MinLength(6)] public string Password { get; set; }
}
