using CarBooking.Application.Features.Mediator.Queries.StatisticQueries;
using CarBooking.Application.Features.Mediator.Results.StatisticResults;
using CarBooking.Application.Interfaces.StatisticInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.StatisticHandlers;
public class GetAvgRentPriceForWeeklyQueryHandler : IRequestHandler<GetAvgRentPriceForWeeklyQuery, GetAvgRentPriceForWeeklyQueryResult>
{
    private readonly IStatisticRepository _repository;

    public GetAvgRentPriceForWeeklyQueryHandler(IStatisticRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetAvgRentPriceForWeeklyQueryResult> Handle(GetAvgRentPriceForWeeklyQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetAvgRentPriceForWeekly();
        return new GetAvgRentPriceForWeeklyQueryResult
        {
            AvgRentPriceForWeekl = value
        };
    }
}
