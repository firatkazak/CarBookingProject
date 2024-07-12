using CarBooking.Application.Features.Mediator.Queries.StatisticQueries;
using CarBooking.Application.Features.Mediator.Results.StatisticResults;
using CarBooking.Application.Interfaces.StatisticInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.StatisticHandlers;
public class GetCarCountByKmSmallerThen1000QueryHandler : IRequestHandler<GetCarCountByKmSmallerThen1000Query, GetCarCountByKmSmallerThen1000QueryResult>
{
    private readonly IStatisticRepository _repository;

    public GetCarCountByKmSmallerThen1000QueryHandler(IStatisticRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetCarCountByKmSmallerThen1000QueryResult> Handle(GetCarCountByKmSmallerThen1000Query request, CancellationToken cancellationToken)
    {
        var value = _repository.GetCarCountByKmSmallerThen1000();
        return new GetCarCountByKmSmallerThen1000QueryResult
        {
            CarCountByKmSmallerThen1000 = value
        };
    }
}
