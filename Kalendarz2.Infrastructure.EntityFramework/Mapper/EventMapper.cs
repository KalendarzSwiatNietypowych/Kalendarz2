using Kalendarz2.Domain.Common;
using Kalendarz2.Domain.Common.Models.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz2.Infrastructure.EntityFramework.Mapper;

public class EventMapper
{
    public EventDTO Map(NewEventDTO newEvent, int id, ICollection<ParticipantDTO> participants)
    {
        return new EventDTO
        {
            Id = id,
            Title = newEvent.Title,
            Description = newEvent.Description,
            Location = newEvent.Location,
            Participants = participants,
            StartEvent = newEvent.StartEvent,
            EndEvent = newEvent.EndEvent,
            Color = newEvent.Color,
        };
    }
    public Event Map(NewEventDTO newEvent)
    {
        return new Event
        {
            Title = newEvent.Title,
            Description = newEvent.Description,
            Location = newEvent.Location,
            StartEvent = newEvent.StartEvent,
            EndEvent = newEvent.EndEvent,
            IsRecurring = newEvent.IsRecurring,
        };
    }
    public EventDTO Map(Event newEvent, ICollection<ParticipantDTO> participants)
    {
        return new EventDTO
        {
            Id = newEvent.Id,
            Title = newEvent.Title,
            Description = newEvent.Description,
            Location = newEvent.Location,
            Participants = participants,
            StartEvent = newEvent.StartEvent,
            EndEvent = newEvent.EndEvent,
        };
    }
}
