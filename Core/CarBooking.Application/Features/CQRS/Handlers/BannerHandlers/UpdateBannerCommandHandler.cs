using CarBooking.Application.Features.CQRS.Commands.BannerCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;

namespace CarBooking.Application.Features.CQRS.Handlers.BannerHandlers;
public class UpdateBannerCommandHandler
{
    private readonly IRepository<Banner> _repository;

    public UpdateBannerCommandHandler(IRepository<Banner> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateBannerCommand command)
    {
        var values = await _repository.GetByIdAsync(command.BannerID);
        values.Description = command.Description;
        values.Title = command.Title;
        values.VideoDescription = command.VideoDescription;
        values.VideoUrl = command.VideoUrl;
        await _repository.UpdateAsync(values);
    }

}
