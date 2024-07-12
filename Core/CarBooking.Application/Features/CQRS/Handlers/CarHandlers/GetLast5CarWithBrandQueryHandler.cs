using CarBooking.Application.Features.CQRS.Results.CarResults;
using CarBooking.Application.Interfaces.CarInterfaces;

namespace CarBooking.Application.Features.CQRS.Handlers.CarHandlers;

public class GetLast5CarWithBrandQueryHandler
{
    private readonly ICarRepository _repository;

    public GetLast5CarWithBrandQueryHandler(ICarRepository repository)
    {
        _repository = repository;
    }

    public List<GetCarWithBrandQueryResult> Handle()
    {
        var values = _repository.GetLast5CarsWithBrands();
        return values.Select(x => new GetCarWithBrandQueryResult
        {
            BigImageUrl = x.BigImageUrl,
            BrandID = x.BrandID,
            BrandName = x.Brand.Name,
            CarID = x.CarID,
            CoverImageUrl = x.CoverImageUrl,
            Fuel = x.Fuel,
            Km = x.Km,
            Luggage = x.Luggage,
            Model = x.Model,
            Seat = x.Seat,
            Transmission = x.Transmission,
        }).ToList();
    }

}
