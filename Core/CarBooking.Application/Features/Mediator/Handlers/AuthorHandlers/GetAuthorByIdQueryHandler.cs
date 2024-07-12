using CarBooking.Application.Features.Mediator.Queries.AuthorQueries;
using CarBooking.Application.Features.Mediator.Results.AuthorResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;

namespace CarBooking.Application.Authors.Mediator.Handlers.AuthorHandlers;
public class GetAuthorByIdQueryHandler
{
    private readonly IRepository<Author> _repository;

    public GetAuthorByIdQueryHandler(IRepository<Author> repository)
    {
        _repository = repository;
    }

    public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.Id);
        return new GetAuthorByIdQueryResult
        {
            AuthorID = values.AuthorID,
            Description = values.Description,
            ImageUrl = values.ImageUrl,
            Name = values.Name
        };
    }
}
