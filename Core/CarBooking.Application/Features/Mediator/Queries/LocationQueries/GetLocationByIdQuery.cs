using CarBooking.Application.Features.Mediator.Results.LocationResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.LocationQueries;
public class GetLocationByIdQuery : IRequest<GetLocationByIdQueryResult>
{
    public GetLocationByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
