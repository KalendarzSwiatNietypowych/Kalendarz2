namespace Kalendarz2.Domain.Common.Exceptions;

public class EditUserException : Exception
{
    public EditUserException() : base("Invalid update user")
    { }
}
