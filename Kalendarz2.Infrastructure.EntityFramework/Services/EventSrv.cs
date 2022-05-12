using Kalendarz2.Domain.Common;
using Kalendarz2.Domain.Interfaces.Infrastucture;

namespace Kalendarz2.Infrastructure.EntityFramework;

public class EventSrv : IEventSrv
{

    private readonly CalendarDbContext _dbContext;

    public EventSrv(CalendarDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public EventDTO AddEvent(NewEventDTO addeventDTO)
    {

    }
    public EventDTO ModifyEvent(NewEventDTO modifyeventDTO)
    {

    }

}
