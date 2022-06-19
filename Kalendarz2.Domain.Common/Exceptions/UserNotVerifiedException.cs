using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz2.Domain.Common.Exceptions;

public class UserNotVerifiedException : Exception
{
    public UserNotVerifiedException() : base("User is not verified")
    { }
}
