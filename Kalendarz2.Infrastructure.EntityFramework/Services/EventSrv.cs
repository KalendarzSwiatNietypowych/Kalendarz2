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
    public EventDTO AddEvent(NewEventDTO addeventDTO)
    {
        var participantEmails = addeventDTO.ParticipantsEmails;
        var participantList = new List<ParticipantDTO>();

        foreach (var email in participantEmails)
        {
            var participant = _accountSrv.GetParticipantByMail(email);
            if(participant != null) participantList.Add(participant);
        }
        var author = _dbContext.Users.FirstOrDefault(u => u.Id == addeventDTO.AuthorId);
        participantList.Add(_accountSrv.GetParticipantByMail(author.Email));

        var newEvent = _eventMapper.Map(addeventDTO);
        _dbContext.Events.Add(newEvent);
        _dbContext.SaveChanges();

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
        _dbContext.Events.Update(newEvent);
        _dbContext.SaveChanges();

        var eventDTO = _eventMapper.Map(addeventDTO, newEvent.Id, participantList);

        return eventDTO;
    }
    public EventDTO ModifyEvent(NewEventDTO modifyeventDTO)
    {
        return null;
        //zmienic
    }

}
