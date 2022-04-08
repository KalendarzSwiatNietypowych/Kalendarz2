using System.ComponentModel.DataAnnotations;

namespace Backend.Models.User;

public class ResetPasswordDTO
{
    public string Email { get; set; }
    [Required][MinLength(6)] public string Password { get; set; }
}
