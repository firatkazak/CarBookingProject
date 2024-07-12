using MediatR;

namespace CarBooking.Application.Features.Mediator.Commands.CommentCommands;
public class CreateCommentCommand : IRequest
{
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
    public int BlogID { get; set; }
    public string Description { get; set; }
    public string Email { get; set; }
}
