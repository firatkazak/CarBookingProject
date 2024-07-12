using CarBooking.Application.Features.Mediator.Queries.StatisticQueries;
using CarBooking.Application.Features.Mediator.Results.StatisticResults;
using CarBooking.Application.Interfaces.StatisticInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.StatisticHandlers;
public class GetAuthorCountQueryHandler : IRequestHandler<GetAuthorCountQuery, GetAuthorCountQueryResult>
{
    private readonly IStatisticRepository _repository;

    public GetAuthorCountQueryHandler(IStatisticRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetAuthorCountQueryResult> Handle(GetAuthorCountQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetAuthorCount();
        return new GetAuthorCountQueryResult
        {
            AuthorCount = value
        };
    }
}
