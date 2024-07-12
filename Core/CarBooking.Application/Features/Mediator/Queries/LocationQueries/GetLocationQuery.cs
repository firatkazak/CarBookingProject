using CarBooking.Application.Features.Mediator.Results.LocationResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.LocationQueries;
public class GetLocationQuery : IRequest<List<GetLocationQueryResult>>
{

}
