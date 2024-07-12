using CarBooking.Application.Features.Mediator.Commands.TagCloudCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.TagCloudHandlers;
public class RemovePricingCommandHandler : IRequestHandler<RemoveTagCloudCommand>
{
    private readonly IRepository<TagCloud> _repository;

    public RemovePricingCommandHandler(IRepository<TagCloud> repository)
    {
        _repository = repository;
    }
    public async Task Handle(RemoveTagCloudCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}
