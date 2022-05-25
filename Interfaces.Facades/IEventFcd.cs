using Kalendarz2.Domain.Common;
using Kalendarz2.Domain.Common.Models.Event;

namespace Kalendarz2.Domain.Interfaces.Facades;

public interface IEventFcd
{ 
    EventDTO AddEvent(NewEventDTO addEventDTO);
    EventDTO ModifyEvent(EditEventDTO editEventDTO);
    EventDTO GetEvent(EventOwnerDTO getEventDTO);
    List<EventDTO> GetEventsByUser(GetByUserDTO getByUserDTO);
    EventDTO DeleteEvent(EventOwnerDTO deleteEventDTO);

}
