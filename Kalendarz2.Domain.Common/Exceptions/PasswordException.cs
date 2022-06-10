using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz2.Domain.Common.Exceptions;

public class PasswordException : Exception
{
    public PasswordException() : base("Invalid password")
    { }
}