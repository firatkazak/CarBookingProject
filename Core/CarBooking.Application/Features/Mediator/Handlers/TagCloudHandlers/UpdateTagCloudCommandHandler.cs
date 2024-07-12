using CarBooking.Application.Features.Mediator.Commands.TagCloudCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.TagCloudHandlers;
public class UpdatePricingCommandHandler : IRequestHandler<UpdateTagCloudCommand>
{
    private readonly IRepository<TagCloud> _repository;
    public UpdatePricingCommandHandler(IRepository<TagCloud> repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateTagCloudCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.TagCloudID);
        values.Title = request.Title;
        values.BlogID = request.BlogID;
        await _repository.UpdateAsync(values);
    }
}
