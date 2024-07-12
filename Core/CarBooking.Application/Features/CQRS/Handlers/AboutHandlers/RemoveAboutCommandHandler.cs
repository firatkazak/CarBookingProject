using CarBooking.Application.Features.CQRS.Commands.AboutCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;

namespace CarBooking.Application.Features.CQRS.Handlers.AboutHandlers;
public class RemoveAboutCommandHandler
{
    private readonly IRepository<About> _repository;

    public RemoveAboutCommandHandler(IRepository<About> repository)
    {
        _repository = repository;
    }

    public async Task Handle(RemoveAboutCommand command)
    {
        var value = await _repository.GetByIdAsync(command.Id);
        await _repository.RemoveAsync(value);
    }

}
