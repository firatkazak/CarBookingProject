using MediatR;

namespace CarBooking.Application.Features.Mediator.Commands.CarFeatureCommands;
public class UpdateCarFeatureAvailableChangeToFalseCommand : IRequest
{
    public int Id { get; set; }

    public UpdateCarFeatureAvailableChangeToFalseCommand(int id)
    {
        Id = id;
    }
}