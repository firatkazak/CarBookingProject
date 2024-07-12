using CarBooking.Application.Features.Mediator.Commands.AuthorCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.AuthorHandlers;
public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand>
{
    private readonly IRepository<Author> _repository;

    public CreateAuthorCommandHandler(IRepository<Author> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Author
        {
            Description = request.Description,
            ImageUrl = request.ImageUrl,
            Name = request.Name,
        });
    }
}
