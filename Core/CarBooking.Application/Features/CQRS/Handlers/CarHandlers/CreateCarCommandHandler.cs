using CarBooking.Application.Features.CQRS.Commands.CarCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;

namespace CarBooking.Application.Features.CQRS.Handlers.CarHandlers;
public class CreateCarCommandHandler
{
    private readonly IRepository<Car> _repository;

    public CreateCarCommandHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateCarCommand command)
    {
        await _repository.CreateAsync(new Car
        {
            BigImageUrl = command.BigImageUrl,
            BrandID = command.BrandID,
            CoverImageUrl = command.CoverImageUrl,
            Fuel = command.Fuel,
            Km = command.Km,
            Luggage = command.Luggage,
            Model = command.Model,
            Seat = command.Seat,
            Transmission = command.Transmission,
        });
    }

}
