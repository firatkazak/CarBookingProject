using CarBooking.Application.Features.Mediator.Results.TagCloudResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.TagCloudQueries;
public class GetTagCloudQuery : IRequest<List<GetTagCloudQueryResult>>
{

}
