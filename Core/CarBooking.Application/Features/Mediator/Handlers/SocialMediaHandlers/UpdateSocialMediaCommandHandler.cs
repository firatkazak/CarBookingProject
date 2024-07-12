using CarBooking.Application.Features.Mediator.Commands.SocialMediaCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.SocialMediaHandlers;
public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommand>
{
    private readonly IRepository<SocialMedia> _repository;

    public UpdateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.SocialMediaID);
        values.Icon = request.Icon;
        values.Name = request.Name;
        values.SocialMediaID = request.SocialMediaID;
        values.Url = request.Url;
        await _repository.UpdateAsync(values);
    }
}
