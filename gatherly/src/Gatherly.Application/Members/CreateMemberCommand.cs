using MediatR;

namespace Gatherly.Application.Members;

public sealed record CreateMemberCommand(
    string Email,
    string FirstName,
    string LastName) : IRequest;