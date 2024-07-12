using CarBooking.Application.Features.Mediator.Queries.BlogQueries;
using CarBooking.Application.Features.Mediator.Results.BlogResults;
using CarBooking.Application.Interfaces.BlogInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.BlogHandlers;
public class GetBlogByAuthorIdQueryHandler : IRequestHandler<GetBlogByAuthorIdQuery, List<GetBlogByAuthorIdQueryResult>>
{
    private readonly IBlogRepository _repository;
    public GetBlogByAuthorIdQueryHandler(IBlogRepository repository)
    {
        _repository = repository;
    }
    public async Task<List<GetBlogByAuthorIdQueryResult>> Handle(GetBlogByAuthorIdQuery request, CancellationToken cancellationToken)
    {
        var values = _repository.GetBlogByAuthorId(request.Id);
        return values.Select(x => new GetBlogByAuthorIdQueryResult
        {
            AuthorID = x.AuthorID,
            BlogID = x.BlogID,
            AuthorName = x.Author.Name,
            AuthorDescription = x.Author.Description,
            AuthorImageUrl = x.Author.ImageUrl,
        }).ToList();
    }
}
