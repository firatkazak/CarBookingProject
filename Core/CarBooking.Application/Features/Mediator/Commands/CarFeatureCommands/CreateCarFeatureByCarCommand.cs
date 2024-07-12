using MediatR;

namespace CarBooking.Application.Features.Mediator.Commands.CarFeatureCommands;
public class CreateCarFeatureByCarCommand : IRequest
{
    public int CarID { get; set; }
    public int FeatureID { get; set; }
    public bool Available { get; set; }
}