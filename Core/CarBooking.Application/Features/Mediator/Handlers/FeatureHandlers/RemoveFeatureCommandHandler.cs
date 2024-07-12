using CarBooking.Application.Features.Mediator.Commands.FeatureCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.FeatureHandlers;
public class RemoveFeatureCommandHandler : IRequestHandler<RemoveFeatureCommand>
{
    private readonly IRepository<Feature> _repository;
    public RemoveFeatureCommandHandler(IRepository<Feature> repository)
    {
        _repository = repository;
    }
    public async Task Handle(RemoveFeatureCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}
