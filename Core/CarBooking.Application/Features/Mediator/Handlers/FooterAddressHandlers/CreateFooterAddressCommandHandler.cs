using CarBooking.Application.Features.Mediator.Commands.FooterAddressCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.FooterAddressHandlers;
public class CreateFooterAddressCommandHandler : IRequestHandler<CreateFooterAddressCommand>
{
    private readonly IRepository<FooterAddress> _repository;

    public CreateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateFooterAddressCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new FooterAddress
        {
            Address = request.Address,
            Description = request.Description,
            Email = request.Email,
            Phone = request.Phone
        });
    }
}
