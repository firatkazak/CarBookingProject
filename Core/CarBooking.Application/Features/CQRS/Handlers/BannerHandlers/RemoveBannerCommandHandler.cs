using CarBooking.Application.Features.CQRS.Commands.BannerCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;

namespace CarBooking.Application.Features.CQRS.Handlers.BannerHandlers;
public class RemoveBannerCommandHandler
{
    private readonly IRepository<Banner> _repository;

    public RemoveBannerCommandHandler(IRepository<Banner> repository)
    {
        _repository = repository;
    }

    public async Task Handle(RemoveBannerCommand command)
    {
        var value = await _repository.GetByIdAsync(command.Id);
        await _repository.RemoveAsync(value);
    }

}
