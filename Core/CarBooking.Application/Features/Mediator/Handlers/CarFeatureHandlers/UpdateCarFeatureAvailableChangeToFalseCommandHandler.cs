using CarBooking.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBooking.Application.Interfaces.CarFeatureInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.CarFeatureHandlers;
public class UpdateCarFeatureAvailableChangeToFalseCommandHandler : IRequestHandler<UpdateCarFeatureAvailableChangeToFalseCommand>
{
    private readonly ICarFeatureRepository _repository;
    public UpdateCarFeatureAvailableChangeToFalseCommandHandler(ICarFeatureRepository repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateCarFeatureAvailableChangeToFalseCommand request, CancellationToken cancellationToken)
    {
        _repository.ChangeCarFeatureAvailableToFalse(request.Id);
    }
}