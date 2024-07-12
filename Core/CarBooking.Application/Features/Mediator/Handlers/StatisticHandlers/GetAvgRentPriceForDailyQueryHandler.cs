using CarBooking.Application.Features.Mediator.Queries.StatisticQueries;
using CarBooking.Application.Features.Mediator.Results.StatisticResults;
using CarBooking.Application.Interfaces.StatisticInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.StatisticHandlers;
public class GetAvgRentPriceForDailyQueryHandler : IRequestHandler<GetAvgRentPriceForDailyQuery, GetAvgRentPriceForDailyQueryResult>
{
    private readonly IStatisticRepository _repository;

    public GetAvgRentPriceForDailyQueryHandler(IStatisticRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetAvgRentPriceForDailyQueryResult> Handle(GetAvgRentPriceForDailyQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetAvgRentPriceForDaily();
        return new GetAvgRentPriceForDailyQueryResult
        {
            AvgPriceForDaily = value
        };
    }
}
