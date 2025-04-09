using Gatherly.Domain.Shared;

namespace Gatherly.Domain.Errors;

public static class DomainError
{
    public static class Gathering
    {
        public static readonly Error InvitingCreator = new(
            "Gathering.InvitingCreator",
            "Can't send invitation to the gathering creator.");

        public static readonly Error AlreadyPassed = new(
            "Gathering.AlreadyPassed",
            "Can't send invitation for gathering in the past.");
    }
}