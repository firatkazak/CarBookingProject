using CarBooking.Application.Features.Mediator.Commands.AuthorCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Authors.Mediator.Handlers.AuthorHandlers;
public class RemoveAuthorCommandHandler : IRequestHandler<RemoveAuthorCommand>
{
    private readonly IRepository<Author> _repository;
    public RemoveAuthorCommandHandler(IRepository<Author> repository)
    {
        _repository = repository;
    }
    public async Task Handle(RemoveAuthorCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}
