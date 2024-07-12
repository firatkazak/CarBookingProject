using CarBooking.Application.Features.Mediator.Queries.StatisticQueries;
using CarBooking.Application.Features.Mediator.Results.StatisticResults;
using CarBooking.Application.Interfaces.StatisticInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.StatisticHandlers;
public class GetCarBrandAndModelByRentPriceDailyMinQueryHandler : IRequestHandler<GetCarBrandAndModelByRentPriceDailyMinQuery, GetCarBrandAndModelByRentPriceDailyMinQueryResult>
{
    private readonly IStatisticRepository _repository;

    public GetCarBrandAndModelByRentPriceDailyMinQueryHandler(IStatisticRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetCarBrandAndModelByRentPriceDailyMinQueryResult> Handle(GetCarBrandAndModelByRentPriceDailyMinQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetCarBrandAndModelByRentPriceDailyMin();
        return new GetCarBrandAndModelByRentPriceDailyMinQueryResult
        {
            CarBrandAndModelByRentPriceDailyMin = value
        };
    }
}
