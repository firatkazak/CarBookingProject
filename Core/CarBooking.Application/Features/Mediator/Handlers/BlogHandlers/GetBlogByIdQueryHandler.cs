using CarBooking.Application.Features.Mediator.Queries.BlogQueries;
using CarBooking.Application.Features.Mediator.Results.BlogResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.BlogHandlers;
public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
{
    private readonly IRepository<Blog> _repository;

    public GetBlogByIdQueryHandler(IRepository<Blog> repository)
    {
        _repository = repository;
    }

    public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.Id);

        return new GetBlogByIdQueryResult
        {
            BlogID = values.BlogID,
            AuthorID = values.AuthorID,
            CategoryID = values.CategoryID,
            CoverImageUrl = values.CoverImageUrl,
            CreatedDate = values.CreatedDate,
            Description = values.Description,
            Title = values.Title
        };
    }
}
