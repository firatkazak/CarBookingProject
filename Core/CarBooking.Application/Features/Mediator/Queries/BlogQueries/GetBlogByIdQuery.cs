using CarBooking.Application.Features.Mediator.Results.BlogResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.BlogQueries;
public class GetBlogByIdQuery : IRequest<GetBlogByIdQueryResult>
{
    public GetBlogByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
