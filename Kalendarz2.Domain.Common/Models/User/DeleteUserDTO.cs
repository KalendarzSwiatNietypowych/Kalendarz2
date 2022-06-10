using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz2.Domain.Common.Models.User;

public class DeleteUserDTO
{
    [Required] public int UserId { get; set; }
    [Required] public string Password { get; set; }
}
