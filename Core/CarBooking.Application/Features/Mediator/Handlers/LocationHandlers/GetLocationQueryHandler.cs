using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;
using CarBooking.Application.Features.Mediator.Queries.LocationQueries;
using CarBooking.Application.Features.Mediator.Results.LocationResults;

namespace CarBooking.Application.Locations.Mediator.Handlers.LocationHandlers;
public class GetLocationQueryHandler : IRequestHandler<GetLocationQuery, List<GetLocationQueryResult>>
{
    private readonly IRepository<Location> _repository;

    public GetLocationQueryHandler(IRepository<Location> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetLocationQueryResult
        {
            LocationID = x.LocationID,
            Name = x.Name
        }).ToList();
    }
}
