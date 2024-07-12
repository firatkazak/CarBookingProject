using CarBooking.Application.Features.Mediator.Queries.StatisticQueries;
using CarBooking.Application.Features.Mediator.Results.StatisticResults;
using CarBooking.Application.Interfaces.StatisticInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.StatisticHandlers;
public class GetCarBrandAndModelByRentPriceDailyMaxQueryHandler : IRequestHandler<GetCarBrandAndModelByRentPriceDailyMaxQuery, GetCarBrandAndModelByRentPriceDailyMaxQueryResult>
{
    private readonly IStatisticRepository _repository;

    public GetCarBrandAndModelByRentPriceDailyMaxQueryHandler(IStatisticRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetCarBrandAndModelByRentPriceDailyMaxQueryResult> Handle(GetCarBrandAndModelByRentPriceDailyMaxQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetCarBrandAndModelByRentPriceDailyMax();
        return new GetCarBrandAndModelByRentPriceDailyMaxQueryResult
        {
            CarBrandAndModelByRentPriceDailyMax = value
        };
    }
}
