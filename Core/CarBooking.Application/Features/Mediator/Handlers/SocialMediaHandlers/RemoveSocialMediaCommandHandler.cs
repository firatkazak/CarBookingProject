using CarBooking.Application.Features.Mediator.Commands.SocialMediaCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.SocialMediaHandlers;
public class RemoveSocialMediaCommandHandler : IRequestHandler<RemoveSocialMediaCommand>
{
    private readonly IRepository<SocialMedia> _repository;
    public RemoveSocialMediaCommandHandler(IRepository<SocialMedia> repository)
    {
        _repository = repository;
    }
    public async Task Handle(RemoveSocialMediaCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}
