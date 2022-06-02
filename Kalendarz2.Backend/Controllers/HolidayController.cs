using Kalendarz2.Domain.Interfaces.Facades;
using Microsoft.AspNetCore.Mvc;

namespace Kalendarz2.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HolidayController : ControllerBase
{
    private readonly IHolidayFcd _holidayFcd; 

    HolidayController(IHolidayFcd holidayFcd)
    {
        _holidayFcd = holidayFcd;
    }
}
