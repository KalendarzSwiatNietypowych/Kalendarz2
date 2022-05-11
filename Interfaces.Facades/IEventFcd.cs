using Kalendarz2.Domain.Common;

namespace Kalendarz2.Domain.Interfaces.Facades;

public interface IEventFcd
{ 
    EventDTO AddEvent(AddEventDTO addeventDTO);
    EventDTO ModifyEvent(ModifyEventDTO modifyeventDTO);

}
