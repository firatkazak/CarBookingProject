using CarBooking.Application.Features.Mediator.Commands.FooterAddressCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.FooterAddressHandlers;
public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
{
    private readonly IRepository<FooterAddress> _repository;

    public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.FooterAddressID);
        values.Address = request.Address;
        values.Description = request.Description;
        values.Email = request.Email;
        values.FooterAddressID = request.FooterAddressID;
        values.Phone = request.Phone;
        await _repository.UpdateAsync(values);
    }
}
