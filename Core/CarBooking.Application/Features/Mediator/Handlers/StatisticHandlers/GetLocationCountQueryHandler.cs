using CarBooking.Application.Features.Mediator.Queries.StatisticQueries;
using CarBooking.Application.Features.Mediator.Results.StatisticResults;
using CarBooking.Application.Interfaces.StatisticInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.StatisticHandlers;
public class GetLocationCountQueryHandler : IRequestHandler<GetLocationCountQuery, GetLocationCountQueryResult>
{
    private readonly IStatisticRepository _repository;

    public GetLocationCountQueryHandler(IStatisticRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetLocationCountQueryResult> Handle(GetLocationCountQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetLocationCount();
        return new GetLocationCountQueryResult
        {
            LocationCount = value
        };
    }
}
