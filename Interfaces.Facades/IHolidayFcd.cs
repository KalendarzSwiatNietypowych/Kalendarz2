using Kalendarz2.Domain.Common.Models.Holiday;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz2.Domain.Interfaces.Facades;

public interface IHolidayFcd
{
    public AddHolidayDTO addHoliday(AddHolidayDTO holiday);
    public List<HolidayDTO> getHolidays();
    public HolidayDTO deleteHoliday(DeleteHolidayDTO deleteHoliday);
    public HolidayDTO updateHoliday(UpdateHolidayDTO holiday);
}
