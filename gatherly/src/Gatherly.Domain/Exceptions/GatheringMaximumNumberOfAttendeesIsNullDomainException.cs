namespace Gatherly.Domain.Exceptions;

public sealed class GatheringMaximumNumberOfAttendeesIsNullDomainException
    : BaseDomainException
{
    public GatheringMaximumNumberOfAttendeesIsNullDomainException(string message)
        : base(message)
    {
    }
}