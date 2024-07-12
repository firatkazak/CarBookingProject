using CarBooking.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBooking.Application.Features.Mediator.Results.CarPricingResults;
using CarBooking.Application.Interfaces.CarPricingInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.CarPricingHandlers;
public class GetCarPricingQueryHandler : IRequestHandler<GetCarPricingWithCarQuery, List<GetCarPricingWithCarQueryResult>>
{
    private readonly ICarPricingRepository _repository;

    public GetCarPricingQueryHandler(ICarPricingRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetCarPricingWithCarQueryResult>> Handle(GetCarPricingWithCarQuery request, CancellationToken cancellationToken)
    {
        var values = _repository.GetCarPricingWithCars();
        return values.Select(x => new GetCarPricingWithCarQueryResult
        {
            Amount = x.Amount,
            CarPricingId = x.CarPricingID,
        }).ToList();
    }
}
