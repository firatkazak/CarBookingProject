using CarBooking.Application.Features.Mediator.Queries.StatisticQueries;
using CarBooking.Application.Features.Mediator.Results.StatisticResults;
using CarBooking.Application.Interfaces.StatisticInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.StatisticHandlers;
public class GetAvgRentPriceForMonthlyQueryHandler : IRequestHandler<GetAvgRentPriceForMonthlyQuery, GetAvgRentPriceForMonthlyQueryResult>
{
    private readonly IStatisticRepository _repository;

    public GetAvgRentPriceForMonthlyQueryHandler(IStatisticRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetAvgRentPriceForMonthlyQueryResult> Handle(GetAvgRentPriceForMonthlyQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetAvgRentPriceForMonthly();
        return new GetAvgRentPriceForMonthlyQueryResult
        {
            AvgRentPriceForMonthly = value
        };
    }
}
