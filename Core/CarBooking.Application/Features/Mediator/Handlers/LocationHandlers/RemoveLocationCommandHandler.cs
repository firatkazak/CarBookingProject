using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;
using CarBooking.Application.Features.Mediator.Commands.LocationCommands;

namespace CarBooking.Application.Locations.Mediator.Handlers.LocationHandlers;
public class RemoveLocationCommandHandler : IRequestHandler<RemoveLocationCommand>
{
    private readonly IRepository<Location> _repository;
    public RemoveLocationCommandHandler(IRepository<Location> repository)
    {
        _repository = repository;
    }
    public async Task Handle(RemoveLocationCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}
