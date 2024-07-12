using CarBooking.Application.Features.CQRS.Queries.CarQueries;
using CarBooking.Application.Features.CQRS.Results.CarResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;

namespace CarBooking.Application.Features.CQRS.Handlers.CarHandlers;
public class GetCarByIdQueryHandler
{
    private readonly IRepository<Car> _repository;

    public GetCarByIdQueryHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
    {
        var values = await _repository.GetByIdAsync(query.Id);
        return new GetCarByIdQueryResult
        {
            BigImageUrl = values.BigImageUrl,
            BrandID = values.BrandID,
            CarID = values.CarID,
            CoverImageUrl = values.CoverImageUrl,
            Fuel = values.Fuel,
            Km = values.Km,
            Luggage = values.Luggage,
            Model = values.Model,
            Seat = values.Seat,
            Transmission = values.Transmission
        };
    }
}
