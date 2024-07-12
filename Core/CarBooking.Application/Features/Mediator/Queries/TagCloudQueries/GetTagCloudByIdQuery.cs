using CarBooking.Application.Features.Mediator.Results.TagCloudResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.TagCloudQueries;
public class GetTagCloudByIdQuery : IRequest<GetTagCloudByIdQueryResult>
{
    public GetTagCloudByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
