using CarBooking.Application.Features.Mediator.Commands.CommentCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.CommentHandlers;
public class CreateCommentHandler : IRequestHandler<CreateCommentCommand>
{
    private readonly IRepository<Comment> _repository;

    public CreateCommentHandler(IRepository<Comment> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateCommentCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Comment
        {
            BlogID = request.BlogID,
            CreatedDate = DateTime.Parse(DateTime.Now.ToShortDateString()),
            Description = request.Description,
            Email = request.Email,
            Name = request.Name
        });
    }
}
