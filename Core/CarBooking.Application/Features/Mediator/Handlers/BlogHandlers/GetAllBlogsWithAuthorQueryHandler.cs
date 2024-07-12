using CarBooking.Application.Features.Mediator.Queries.BlogQueries;
using CarBooking.Application.Features.Mediator.Results.BlogResults;
using CarBooking.Application.Interfaces.BlogInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.BlogHandlers;
public class GetAllBlogsWithAuthorQueryHandler : IRequestHandler<GetAllBlogsWithAuthorQuery, List<GetAllBlogsWithAuthorQueryResult>>
{
    private readonly IBlogRepository _repository;
    public GetAllBlogsWithAuthorQueryHandler(IBlogRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetAllBlogsWithAuthorQueryResult>> Handle(GetAllBlogsWithAuthorQuery request, CancellationToken cancellationToken)
    {
        var values = _repository.GetAllBlogsWithAuthors();
        return values.Select(x => new GetAllBlogsWithAuthorQueryResult
        {
            AuthorID = x.AuthorID,
            BlogID = x.BlogID,
            CategoryID = x.CategoryID,
            CoverImageUrl = x.CoverImageUrl,
            CreatedDate = x.CreatedDate,
            Title = x.Title,
            AuthorName = x.Author.Name,
            Description = x.Description,
            AuthorDescription = x.Author.Description,
            AuthorImageUrl = x.Author.ImageUrl
        }).ToList();
    }
}
