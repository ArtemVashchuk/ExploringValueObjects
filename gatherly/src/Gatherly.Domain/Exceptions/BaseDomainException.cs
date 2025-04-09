namespace Gatherly.Domain.Exceptions;

public class BaseDomainException : Exception
{
    protected BaseDomainException(string message)
        : base(message)
    {
    }
}