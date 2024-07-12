using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;
using CarBooking.Application.Features.Mediator.Commands.LocationCommands;

namespace CarBooking.Application.Locations.Mediator.Handlers.LocationHandlers;
public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand>
{
    private readonly IRepository<Location> _repository;

    public UpdateLocationCommandHandler(IRepository<Location> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.LocationID);
        values.Name = request.Name;
        await _repository.UpdateAsync(values);
    }
}
