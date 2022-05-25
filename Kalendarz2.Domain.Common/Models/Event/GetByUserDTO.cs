using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz2.Domain.Common.Models.Event;

public class GetByUserDTO
{
    [Required]
    public int AuthorId { get; set; }
}
