using Gatherly.Domain.Entities;
using Gatherly.Domain.Repositories;
using Gatherly.Domain.ValueObjects;
using MediatR;

namespace Gatherly.Application.Members;

public class CreateMemberCommandHandler(
    IMemberRepository memberRepository,
    IUnitOfWork unitOfWork)
    : IRequestHandler<CreateMemberCommand>
{
    public async Task<Unit> Handle(CreateMemberCommand request, CancellationToken cancellationToken)
    {
        var firstNameResult = FirstName.Create(request.FirstName);

        if (firstNameResult.IsFailure)
        {
            // log
            
            return Unit.Value;
        }
        
        var member = new Member(
            Guid.NewGuid(),
            firstNameResult.Value(),
            request.LastName,
            request.Email);

        memberRepository.Add(member);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}