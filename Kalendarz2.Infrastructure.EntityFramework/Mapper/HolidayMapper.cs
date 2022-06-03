using Kalendarz2.Domain.Common.Models.Holiday;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz2.Infrastructure.EntityFramework.Mapper;

public class HolidayMapper
{
    public Holiday Map(HolidayDTO holiday)
    {
        return new Holiday
        {
            Name = holiday.Name,
            Date = holiday.Date,
            Description = holiday.Description,
        };
    }

    public HolidayDTO Map(Holiday holiday)
    {
        return new HolidayDTO
        {
            Name = holiday.Name,
            Date = holiday.Date,
            Description = holiday.Description
        };
    }

    public HolidayDTO Map(UpdateHolidayDTO holiday)
    {
        return new HolidayDTO
        {
            Name = holiday.Name,
            Date = holiday.Date,
            Description = holiday.Description
        };
    }
}
