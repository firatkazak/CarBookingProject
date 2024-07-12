using CarBooking.Application.Features.CQRS.Commands.AboutCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;

namespace CarBooking.Application.Features.CQRS.Handlers.AboutHandlers;
public class CreateAboutCommandHandler
{
    private readonly IRepository<About> _repository;

    public CreateAboutCommandHandler(IRepository<About> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateAboutCommand command)
    {
        await _repository.CreateAsync(new About
        {
            Description = command.Description,
            ImageUrl = command.ImageUrl,
            Title = command.Title,
        });
    }

}
