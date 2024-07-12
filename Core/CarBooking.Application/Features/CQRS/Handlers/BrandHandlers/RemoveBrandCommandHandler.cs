using CarBooking.Application.Features.CQRS.Commands.BrandCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;

namespace CarBooking.Application.Features.CQRS.Handlers.BrandHandlers;
public class RemoveBrandCommandHandler
{
    private readonly IRepository<Brand> _repository;

    public RemoveBrandCommandHandler(IRepository<Brand> repository)
    {
        _repository = repository;
    }

    public async Task Handle(RemoveBrandCommand command)
    {
        var value = await _repository.GetByIdAsync(command.Id);
        await _repository.RemoveAsync(value);
    }
}
