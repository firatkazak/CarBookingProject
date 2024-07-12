using CarBooking.Application.Features.Mediator.Commands.ServiceCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.ServiceHandlers;
public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand>
{
    private readonly IRepository<Service> _repository;

    public CreateServiceCommandHandler(IRepository<Service> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateServiceCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Service
        {
            Description = request.Description,
            IconUrl = request.IconUrl,
            Title = request.Title,
        });
    }
}
