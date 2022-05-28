using Kalendarz2.Domain.Common;
using Kalendarz2.Domain.Common.Models.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz2.Infrastructure.EntityFramework.Mapper;

public class UserMapper
{
    public UserDTO Map(RegisterDTO newUser, int id)
    {
        return new UserDTO
        {
            Id = id,
            FirstName = newUser.FirstName,
            LastName = newUser.LastName, 

        };
    }

    public User Map(RegisterDTO newUser)
    {
        return new User
        {

            FirstName = newUser.FirstName,
            LastName = newUser.LastName,

        };
    }
    public User Map(EditUserDTO newUser)
    {
        return new User
        {

            FirstName = newUser.FirstName,
            LastName = newUser.LastName,

        };
    }

} 