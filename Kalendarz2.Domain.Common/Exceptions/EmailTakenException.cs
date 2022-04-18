using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz2.Domain.Common.Exceptions;

public class EmailTakenException: Exception
{
    public EmailTakenException() : base("That email is taken")
    { }
}
