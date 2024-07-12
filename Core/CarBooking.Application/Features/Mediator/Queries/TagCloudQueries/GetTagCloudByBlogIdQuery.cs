using CarBooking.Application.Features.Mediator.Results.TagCloudResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.TagCloudQueries;
public class GetTagCloudByBlogIdQuery : IRequest<List<GetTagCloudByBlogIdQueryResult>>
{
    public GetTagCloudByBlogIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
