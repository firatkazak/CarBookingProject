using CarBooking.Application.Features.CQRS.Commands.AboutCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;

namespace CarBooking.Application.Features.CQRS.Handlers.AboutHandlers;
public class UpdateAboutCommandHandler
{
    private readonly IRepository<About> _repository;

    public UpdateAboutCommandHandler(IRepository<About> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateAboutCommand command)
    {
        var values = await _repository.GetByIdAsync(command.AboutID);
        values.Description = command.Description;
        values.ImageUrl = command.ImageUrl;
        values.Title = command.Title;
        await _repository.UpdateAsync(values);
    }

}
