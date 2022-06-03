using Kalendarz2.Domain.Common.Models.Holiday;
using Kalendarz2.Domain.Interfaces.Infrastucture;
using Kalendarz2.Infrastructure.EntityFramework.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz2.Infrastructure.EntityFramework.Services;

public class HolidaySrv : IHolidaySrv
{
    private readonly CalendarDbContext _dbContext;
    private readonly HolidayMapper _holidayMapper;
    public HolidaySrv(CalendarDbContext dbContext, HolidayMapper holidayMapper)
    {
        _dbContext = dbContext;
        _holidayMapper = holidayMapper;
    }

    public AddHolidayDTO addHoliday(AddHolidayDTO holidays)
    {
        foreach(var holiday in holidays.holidays)
        {
            var toAdd = _holidayMapper.Map(holiday);
            _dbContext.Holidays.Add(toAdd);
        }
        _dbContext.SaveChanges();

        return holidays;
    }

    public HolidayDTO deleteHoliday(DeleteHolidayDTO deleteHoliday)
    {
        var toDelete = _dbContext.Holidays.FirstOrDefault(h => h.Id == deleteHoliday.Id);
        _dbContext.Holidays.Remove(toDelete);
        _dbContext.SaveChanges();

        var result = _holidayMapper.Map(toDelete);
        return result;
    }

    public List<HolidayDTO> getHolidays()
    {
        var listHolidaysDTO = new List<HolidayDTO>();
        var holidays = _dbContext.Holidays.ToList();
        foreach(var holiday in holidays)
        {
            var i = _holidayMapper.Map(holiday);
            listHolidaysDTO.Add(i);
        }
        return listHolidaysDTO;
    }

    public HolidayDTO updateHoliday(UpdateHolidayDTO holiday)
    {
        var toUpdate = _dbContext.Holidays.FirstOrDefault(h => h.Id == holiday.Id);
        toUpdate.Name = holiday.Name;
        toUpdate.Date = holiday.Date;
        toUpdate.Description = holiday.Description;

        _dbContext.SaveChanges();

        var result = _holidayMapper.Map(holiday);
        return result;
    }
}
