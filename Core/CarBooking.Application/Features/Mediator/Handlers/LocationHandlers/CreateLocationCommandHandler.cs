﻿using CarBooking.Application.Features.Mediator.Commands.LocationCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.LocationHandlers;
public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommand>
{
    private readonly IRepository<Location> _repository;

    public CreateLocationCommandHandler(IRepository<Location> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateLocationCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Location
        {
            Name = request.Name
        });
    }
}
