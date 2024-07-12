using CarBooking.Application.Features.CQRS.Results.CarResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;

namespace CarBooking.Application.Features.CQRS.Handlers.CarHandlers;
public class GetCarQueryHandler
{
    private readonly IRepository<Car> _repository;

    public GetCarQueryHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetCarQueryResult>> Handle()
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetCarQueryResult
        {
            BigImageUrl = x.BigImageUrl,
            BrandID = x.BrandID,
            CarID = x.CarID,
            CoverImageUrl = x.CoverImageUrl,
            Fuel = x.Fuel,
            Km = x.Km,
            Luggage = x.Luggage,
            Model = x.Model,
            Seat = x.Seat,
            Transmission = x.Transmission
        }).ToList();
    }
}
