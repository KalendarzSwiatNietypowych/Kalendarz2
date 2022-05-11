using Kalendarz2.Domain.Common;
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
    public EventDTO AddEvent(AddEventDTO addeventDTO)
    {
        return _eventSrv.AddEvent(addeventDTO);
    }
    public EventDTO ModifyEvent(ModifyEventDTO modifyeventDTO)
    {
        return _eventSrv.ModifyEvent(modifyeventDTO);
    }

}