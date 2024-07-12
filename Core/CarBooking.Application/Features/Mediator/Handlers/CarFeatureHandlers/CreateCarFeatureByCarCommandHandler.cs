using CarBooking.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBooking.Application.Interfaces.CarFeatureInterfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.CarFeatureHandlers;
public class CreateCarFeatureByCarCommandHandler : IRequestHandler<CreateCarFeatureByCarCommand>
{
    private readonly ICarFeatureRepository _repository;

    public CreateCarFeatureByCarCommandHandler(ICarFeatureRepository repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateCarFeatureByCarCommand request, CancellationToken cancellationToken)
    {
        _repository.CreateCarFeatureByCar(new CarFeature
        {
            Available = false,
            CarID = request.CarID,
            FeatureID = request.FeatureID
        });
    }
}
