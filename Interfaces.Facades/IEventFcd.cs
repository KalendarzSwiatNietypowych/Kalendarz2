using Kalendarz2.Domain.Common;

namespace Kalendarz2.Domain.Interfaces.Facades;

public interface IEventFcd
{ 
    EventDTO AddEvent(NewEventDTO addeventDTO);
    EventDTO ModifyEvent(NewEventDTO modifyeventDTO);

}
