using MediatR;

namespace CarBooking.Application.Features.Mediator.Commands.AuthorCommands;
public class CreateAuthorCommand : IRequest
{
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
}
