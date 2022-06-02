using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz2.Domain.Common.Models.Holiday;

public class HolidayDTO
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
}
