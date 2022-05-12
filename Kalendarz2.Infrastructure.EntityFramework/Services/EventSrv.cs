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

        foreach (var email in participantEmails)
        {
            var participant = _accountSrv.GetParticipantByMail(email);
            if(participant != null) participantList.Add(participant);
        }
        var author = _dbContext.Users.FirstOrDefault(u => u.Id == addEventDTO.AuthorId);
        participantList.Add(_accountSrv.GetParticipantByMail(author.Email));

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
        _dbContext.SaveChanges();

        var eventDTO = _eventMapper.Map(addEventDTO, newEvent.Id, participantList);

        return eventDTO;
        //jeszcze raz przejrzeć
    }
    public EventDTO ModifyEvent(EditEventDTO modifyEventDTO)
    {
        var participantEmails = modifyEventDTO.ParticipantsEmails;
        var eventToUpdate = _dbContext.Events.FirstOrDefault(e => e.Id == modifyEventDTO.Id);

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

        var participantList = new List<ParticipantDTO>();
        foreach (var email in participantEmails)
        {
            var participant = _accountSrv.GetParticipantByMail(email);
            if (participant != null) participantList.Add(participant);
        }

        eventToUpdate = _eventMapper.Map(modifyEventDTO, participationList);
        _dbContext.SaveChanges();

        var result = _eventMapper.Map(eventToUpdate, participantList);
        return result;
        //zobaczyc rano
    }

}
