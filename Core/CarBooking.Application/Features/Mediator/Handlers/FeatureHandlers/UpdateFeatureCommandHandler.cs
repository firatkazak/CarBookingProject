﻿using CarBooking.Application.Features.Mediator.Commands.FeatureCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.FeatureHandlers;
public class UpdateFeatureCommandHandler : IRequestHandler<UpdateFeatureCommand>
{
    private readonly IRepository<Feature> _repository;

    public UpdateFeatureCommandHandler(IRepository<Feature> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.FeatureID);
        values.Name = request.Name;
        await _repository.UpdateAsync(values);
    }
}
