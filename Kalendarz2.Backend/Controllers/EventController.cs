using Kalendarz2.Domain.Common;
using Kalendarz2.Domain.Common.Models.Event;
using Kalendarz2.Domain.Interfaces.Facades;
using Microsoft.AspNetCore.Mvc;


namespace Kalendarz2.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]


public class EventController : ControllerBase
{
    private readonly IEventFcd _eventFcd;

    public EventController(IEventFcd eventFcd)
    {
        _eventFcd = eventFcd;
    }

    [HttpPost("create")]
    public ActionResult AddEvent([FromBody] NewEventDTO addeventDTO)
    {
        return Ok(_eventFcd.AddEvent(addeventDTO));
    }

    [HttpPut("update")]
    public ActionResult EditEvent([FromBody] EditEventDTO editEventDTO)
    {
        return Ok(_eventFcd.ModifyEvent(editEventDTO));
    }

    [HttpPost("get")]
    public ActionResult GetEvent([FromBody] EventOwnerDTO getEventDTO)
    {
        return Ok(_eventFcd.GetEvent(getEventDTO));
    }

    [HttpPost("getByUser")]
    public ActionResult GetEventsByUser([FromBody] EventOwnerDTO getEventsDTO)
    {
        return Ok(_eventFcd.GetEventsByUser(getEventsDTO));
    }

    [HttpPut("delete")]
    public ActionResult DeleteEvent([FromBody] EventOwnerDTO deleteEventDTO)
    {
        return Ok(_eventFcd.DeleteEvent(deleteEventDTO));
    }

}
