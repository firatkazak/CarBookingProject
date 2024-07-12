using CarBooking.Application.Features.CQRS.Commands.CategoryCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;

namespace CarBooking.Application.Features.CQRS.Handlers.CategoryHandlers;
public class CreateCategoryCommandHandler
{
    private readonly IRepository<Category> _repository;

    public CreateCategoryCommandHandler(IRepository<Category> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateCategoryCommand command)
    {
        await _repository.CreateAsync(new Category
        {
            CategoryID = command.CategoryID,
            Name = command.Name,
        });
    }

}
