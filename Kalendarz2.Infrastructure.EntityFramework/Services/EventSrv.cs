using Kalendarz2.Domain.Common;
using Kalendarz2.Domain.Common.Exceptions;
using Kalendarz2.Domain.Common.Models.User;
using Kalendarz2.Domain.Interfaces.Infrastucture;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Kalendarz2.Infrastructure.EntityFramework;
/*
public class EventSrv : IEventSrv
{


    public EventSrv()
    {

    }
    public EventDTO AddEvent(AddEventDTO addeventDTO)
    {

    }
    public EventDTO ModifyEvent(ModifyEventDTO modifyeventDTO)
    {

    }

}

*/