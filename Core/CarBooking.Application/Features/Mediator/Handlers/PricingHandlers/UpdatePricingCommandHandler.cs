using CarBooking.Application.Features.Mediator.Commands.PricingCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.PricingHandlers;
public class UpdatePricingCommandHandler : IRequestHandler<UpdatePricingCommand>
{
    private readonly IRepository<Pricing> _repository;

    public UpdatePricingCommandHandler(IRepository<Pricing> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdatePricingCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.PricingID);
        values.Name = request.Name;
        await _repository.UpdateAsync(values);
    }
}
