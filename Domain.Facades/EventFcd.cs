using Kalendarz2.Domain.Common;
using Kalendarz2.Domain.Common.Models.Event;
using Kalendarz2.Domain.Interfaces.Facades;
using Kalendarz2.Domain.Interfaces.Infrastucture;

namespace Kalendarz2.Domain.Facades;

public class EventFcd : IEventFcd
{
    private readonly IEventSrv _eventSrv;

    public EventFcd(IEventSrv eventSrv)
    {
        _eventSrv = eventSrv;
    }
    public EventDTO AddEvent(NewEventDTO addeventDTO)
    {
        return _eventSrv.AddEvent(addeventDTO);
    }

    public EventDTO DeleteEvent(EventOwnerDTO deleteEventDTO)
    {
        return _eventSrv.DeleteEvent(deleteEventDTO);
    }

    public EventDTO GetEvent(EventOwnerDTO getEventDTO)
    {
        return _eventSrv.GetEvent(getEventDTO);
    }

    public List<EventDTO> GetEventsByUser(EventOwnerDTO getEventsDTO)
    {
        return _eventSrv.GetEventsByUser(getEventsDTO);
    }

    public EventDTO ModifyEvent(EditEventDTO modifyeventDTO)
    {
        return _eventSrv.ModifyEvent(modifyeventDTO);
    }

}