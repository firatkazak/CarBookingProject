using CarBooking.Application.Features.CQRS.Commands.CategoryCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;

namespace CarBooking.Application.Features.CQRS.Handlers.CategoryHandlers;
public class UpdateCategoryCommandHandler
{
    private readonly IRepository<Category> _repository;

    public UpdateCategoryCommandHandler(IRepository<Category> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateCategoryCommand command)
    {
        var values = await _repository.GetByIdAsync(command.CategoryID);
        values.CategoryID = command.CategoryID;
        values.Name = command.Name;
        await _repository.UpdateAsync(values);
    }
}
