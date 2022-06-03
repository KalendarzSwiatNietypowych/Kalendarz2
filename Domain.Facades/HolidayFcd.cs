using Kalendarz2.Domain.Common.Models.Holiday;
using Kalendarz2.Domain.Interfaces.Facades;
using Kalendarz2.Domain.Interfaces.Infrastucture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz2.Domain.Facades;

public class HolidayFcd : IHolidayFcd
{
    private readonly IHolidaySrv _holidaySrv;

    public HolidayFcd(IHolidaySrv holidaySrv)
    {
        _holidaySrv = holidaySrv;
    }
    public AddHolidayDTO addHoliday(AddHolidayDTO holiday)
    {
        return _holidaySrv.addHoliday(holiday);
    }

    public HolidayDTO deleteHoliday(DeleteHolidayDTO deleteHoliday)
    {
        return _holidaySrv.deleteHoliday(deleteHoliday);
    }

    public List<HolidayDTO> getHolidays()
    {
        return _holidaySrv.getHolidays();
    }

    public HolidayDTO updateHoliday(UpdateHolidayDTO holiday)
    {
        return _holidaySrv.updateHoliday(holiday);
    }
}
