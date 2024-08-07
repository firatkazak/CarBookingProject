﻿using CarBooking.Application.Features.CQRS.Commands.ContactCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;

namespace CarBooking.Application.Features.CQRS.Handlers.ContactHandlers;
public class UpdateContactCommandHandler
{
    private readonly IRepository<Contact> _repository;

    public UpdateContactCommandHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateContactCommand command)
    {
        var values = await _repository.GetByIdAsync(command.ContactID);
        values.ContactID = command.ContactID;
        values.Email = command.Email;
        values.Message = command.Message;
        values.Name = command.Name;
        values.SendDate = command.SendDate;
        values.Subject = command.Subject;
        await _repository.UpdateAsync(values);
    }

}
