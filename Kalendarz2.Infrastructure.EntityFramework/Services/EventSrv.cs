using Kalendarz2.Domain.Common;
using Kalendarz2.Domain.Common.Models.Event;
using Kalendarz2.Domain.Interfaces.Infrastucture;
using Kalendarz2.Infrastructure.EntityFramework.Mapper;

namespace Kalendarz2.Infrastructure.EntityFramework;

public class EventSrv : IEventSrv
{
    private readonly CalendarDbContext _dbContext;
    private readonly IAccountSrv _accountSrv;
    private readonly EventMapper _eventMapper;

    public EventSrv(CalendarDbContext dbContext, IAccountSrv accountSrv, EventMapper eventMapper)
    {
        _dbContext = dbContext;
        _accountSrv = accountSrv;
        _eventMapper = eventMapper;
    }
    public EventDTO AddEvent(NewEventDTO addEventDTO)
    {
        var participantEmails = addEventDTO.ParticipantsEmails;
        var participantList = new List<ParticipantDTO>();

        var author = _dbContext.Users.FirstOrDefault(u => u.Id == addEventDTO.AuthorId);
        participantList.Add(_accountSrv.GetParticipantByMail(author.Email));

        foreach (var email in participantEmails)
        {
            var participant = _accountSrv.GetParticipantByMail(email);
            if(participant != null) participantList.Add(participant);
        }

        var newEvent = _eventMapper.Map(addEventDTO);
        _dbContext.Events.Add(newEvent);

        var participationList = new List<Participation>();
        foreach(var email in participantEmails)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Email == email);
            var participation = new Participation()
            {
                EventId = newEvent.Id,
                Event = newEvent,
                ParticipantId = user.Id,
                Participant = user,
            };
            participationList.Add(participation);
        }
        newEvent.Participants = participationList;

        var userParticipation = new Participation() { Event = newEvent, EventId = newEvent.Id, Participant =  author, ParticipantId = author.Id};
        _dbContext.Participations.Add(userParticipation);
        _dbContext.SaveChanges();

        var eventDTO = _eventMapper.Map(addEventDTO, newEvent.Id, participantList);
        return eventDTO;
    }

    public EventDTO DeleteEvent(EventOwnerDTO deleteEventDTO)
    {
        var eventToDelete = _dbContext.Events.FirstOrDefault(e => e.Id == deleteEventDTO.EventId);
        eventToDelete.IsDeleted = true;
        _dbContext.SaveChanges();

        var result = _eventMapper.Map(eventToDelete);
        return result;
    }

    public EventDTO GetEvent(EventOwnerDTO getEventDTO)
    {
        var getEvent = _dbContext.Events.FirstOrDefault(e => e.Id == getEventDTO.EventId);

        var result = _eventMapper.Map(getEvent);
        return result;
    }

    public List<EventDTO> GetEventsByUser(GetByUserDTO getByUserDTO)
    {
        var participations = _dbContext.Participations.Where(p => p.ParticipantId == getByUserDTO.AuthorId).ToList();

        var events = new List<EventDTO>();
        foreach(var participant in participations)
        {
            var eventParticipation = _dbContext.Events.FirstOrDefault(e => e.Id == participant.EventId);
            EventDTO i = _eventMapper.Map(eventParticipation);
            events.Add(i);
        }

        return events;
    }

    public EventDTO ModifyEvent(EditEventDTO modifyEventDTO)
    {
        var eventToUpdate = _dbContext.Events.FirstOrDefault(e => e.Id == modifyEventDTO.Id);

        var participantEmails = modifyEventDTO.ParticipantsEmails;
        var participationList = new List<Participation>();
        foreach (var email in participantEmails)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Email == email);
            var participation = new Participation()
            {
                EventId = eventToUpdate.Id,
                Event = eventToUpdate,
                ParticipantId = user.Id,
                Participant = user,
            };
            participationList.Add(participation);
        }

        eventToUpdate = _eventMapper.Map(modifyEventDTO, participationList);
        _dbContext.Events.Update(eventToUpdate);
        _dbContext.SaveChanges();

        var result = _eventMapper.Map(eventToUpdate);
        return result;
    }

}
