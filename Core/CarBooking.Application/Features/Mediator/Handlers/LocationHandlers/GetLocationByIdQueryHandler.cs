using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;
using CarBooking.Application.Features.Mediator.Queries.LocationQueries;
using CarBooking.Application.Features.Mediator.Results.LocationResults;

namespace CarBooking.Application.Locations.Mediator.Handlers.LocationHandlers;
public class GetLocationByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, GetLocationByIdQueryResult>
{
    private readonly IRepository<Location> _repository;
    public GetLocationByIdQueryHandler(IRepository<Location> repository)
    {
        _repository = repository;
    }

    public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.Id);
        return new GetLocationByIdQueryResult
        {
            LocationID = values.LocationID,
            Name = values.Name
        };
    }
}
