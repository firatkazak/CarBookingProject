using CarBooking.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBooking.Application.Features.Mediator.Results.CarPricingResults;
using CarBooking.Application.Interfaces.CarPricingInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.CarPricingHandlers;
public class GetCarPricingWithTimePeriodQueryHandler : IRequestHandler<GetCarPricingWithTimePeriodQuery, List<GetCarPricingWithTimePeriodQueryResult>>
{
    private readonly ICarPricingRepository _repository;

    public GetCarPricingWithTimePeriodQueryHandler(ICarPricingRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetCarPricingWithTimePeriodQueryResult>> Handle(GetCarPricingWithTimePeriodQuery request, CancellationToken cancellationToken)
    {
        var values = _repository.GetCarPricingWithTimePeriodVM();
        return values.Select(x => new GetCarPricingWithTimePeriodQueryResult
        {
            Brand = x.Brand,
            CoverImageUrl = x.CoverImageUrl,
            Model = x.Model,
            DailyAmount = x.Amounts[0],
            WeeklyAmount = x.Amounts[1],
            MonthlyAmount = x.Amounts[2],
        }).ToList();
    }
}
