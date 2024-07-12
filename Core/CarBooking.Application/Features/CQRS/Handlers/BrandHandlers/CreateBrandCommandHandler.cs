using CarBooking.Application.Features.CQRS.Commands.BrandCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;

namespace CarBooking.Application.Features.CQRS.Handlers.BrandHandlers;
public class CreateBrandCommandHandler
{
    private readonly IRepository<Brand> _repository;

    public CreateBrandCommandHandler(IRepository<Brand> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateBrandCommand command)
    {
        await _repository.CreateAsync(new Brand
        {
            Name = command.Name
        });
    }
}
