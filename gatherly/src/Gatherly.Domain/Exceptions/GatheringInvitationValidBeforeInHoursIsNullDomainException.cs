namespace Gatherly.Domain.Exceptions;

public sealed class GatheringInvitationValidBeforeInHoursIsNullDomainException
    : BaseDomainException
{
    public GatheringInvitationValidBeforeInHoursIsNullDomainException(string message)
        : base(message)
    {
    }
}