using CarBooking.Application.Features.Mediator.Commands.BlogCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.BlogHandlers;
public class RemoveBlogCommandHandler : IRequestHandler<RemoveBlogCommand>
{
    private readonly IRepository<Blog> _repository;
    public RemoveBlogCommandHandler(IRepository<Blog> repository)
    {
        _repository = repository;
    }
    public async Task Handle(RemoveBlogCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}
