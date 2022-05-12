using Kalendarz2.Domain.Common;
using Kalendarz2.Domain.Common.Models.Event;

namespace Kalendarz2.Domain.Interfaces.Infrastucture;

public interface IEventSrv
{
    EventDTO AddEvent(NewEventDTO addEventDTO);
    EventDTO ModifyEvent(EditEventDTO modifyEventDTO);

}
