using CarBooking.Application.Features.Mediator.Queries.AuthorQueries;
using CarBooking.Application.Features.Mediator.Results.AuthorResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Authors.Mediator.Handlers.AuthorHandlers;
public class GetAuthorQueryHandler : IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResult>>
{
    private readonly IRepository<Author> _repository;

    public GetAuthorQueryHandler(IRepository<Author> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetAuthorQueryResult
        {
            AuthorID = x.AuthorID,
            Description = x.Description,
            ImageUrl = x.ImageUrl,
            Name = x.Name
        }).ToList();
    }
}
