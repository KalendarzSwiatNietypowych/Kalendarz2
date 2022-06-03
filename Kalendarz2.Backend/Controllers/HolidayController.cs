using Kalendarz2.Domain.Common.Models.Holiday;
using Kalendarz2.Domain.Interfaces.Facades;
using Microsoft.AspNetCore.Mvc;

namespace Kalendarz2.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HolidayController : ControllerBase
{
    private readonly IHolidayFcd _holidayFcd;

    public HolidayController(IHolidayFcd holidayFcd)
    {
        _holidayFcd = holidayFcd;
    }

    [HttpPost("create")]
    public ActionResult AddHoliday([FromBody] AddHolidayDTO holidayDTO)
    {
        return Ok(_holidayFcd.addHoliday(holidayDTO));
    }

    [HttpPut("update")]
    public ActionResult EditHoliday([FromBody] UpdateHolidayDTO holidayDTO)
    {
        return Ok(_holidayFcd.updateHoliday(holidayDTO));
    }

    [HttpPost("get")]
    public ActionResult GetHolidays()
    {
        return Ok(_holidayFcd.getHolidays());
    }

    [HttpPut("delete")]
    public ActionResult DeleteHoliday([FromBody] DeleteHolidayDTO holidayDTO)
    {
        return Ok(_holidayFcd.deleteHoliday(holidayDTO));
    }

}
