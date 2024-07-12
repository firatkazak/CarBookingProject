using MediatR;

namespace CarBooking.Application.Features.Mediator.Commands.LocationCommands;
public class RemoveLocationCommand : IRequest
{
    public RemoveLocationCommand(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
