using MediatR;

namespace CarBooking.Application.Features.Mediator.Commands.TagCloudCommands;
public class UpdateTagCloudCommand : IRequest
{
    public int TagCloudID { get; set; }
    public string Title { get; set; }
    public int BlogID { get; set; }
}