using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz2.Domain.Common.Models.Holiday;

public class AddHolidayDTO
{
    public List<HolidayDTO> holidays { set; get; }
}
