using Kalendarz2.Domain.Common;
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

        [HttpPost("addevent")]
        public ActionResult AddEvent([FromBody] AddEventDTO addeventDTO)
        {
            return Ok(_eventFcd.AddEvent(addeventDTO));
        }
    }
