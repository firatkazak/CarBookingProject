using CarBooking.Application.Features.Mediator.Results.BlogResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.BlogQueries;
public class GetBlogByAuthorIdQuery : IRequest<List<GetBlogByAuthorIdQueryResult>>
{
    public GetBlogByAuthorIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
