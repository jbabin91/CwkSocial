using CwkSocial.Application.UserProfiles.Commands;
using CwkSocial.Domain.Aggregates.UserProfileAggregate;
using MediatR;

namespace CwkSocial.Application.UserProfiles.CommandHandlers;

internal class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserProfile>
{
    public Task<UserProfile> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
