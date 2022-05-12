using Kalendarz2.Domain.Common;

namespace Kalendarz2.Domain.Interfaces.Infrastucture;

public interface IEventSrv
{
    EventDTO AddEvent(NewEventDTO addeventDTO);
    EventDTO ModifyEvent(NewEventDTO modifyeventDTO);

}
