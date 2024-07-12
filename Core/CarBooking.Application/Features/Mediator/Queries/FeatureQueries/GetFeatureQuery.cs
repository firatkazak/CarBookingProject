using CarBooking.Application.Features.Mediator.Results.FeatureResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.FeatureQueries;
public class GetFeatureQuery : IRequest<List<GetFeatureQueryResult>>
{

}
