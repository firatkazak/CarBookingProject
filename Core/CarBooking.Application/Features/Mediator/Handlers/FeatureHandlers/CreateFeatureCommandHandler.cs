using CarBooking.Application.Features.Mediator.Commands.FeatureCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.FeatureHandlers;
public class CreateFeatureCommandHandler : IRequestHandler<CreateFeatureCommand>
{
    private readonly IRepository<Feature> _repository;
    public CreateFeatureCommandHandler(IRepository<Feature> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateFeatureCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Feature
        {
            Name = request.Name
        });
    }
}
