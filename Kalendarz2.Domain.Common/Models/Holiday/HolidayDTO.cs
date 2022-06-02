using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz2.Domain.Common.Models.Holiday;

public class HolidayDTO
{
    [Required] public string Name { get; set; }
    [Required] public DateTime Date { get; set; }
    public string Description { get; set; }
}
