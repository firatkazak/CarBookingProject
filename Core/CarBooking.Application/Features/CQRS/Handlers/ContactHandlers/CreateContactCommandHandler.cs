using CarBooking.Application.Features.CQRS.Commands.ContactCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;

namespace CarBooking.Application.Features.CQRS.Handlers.ContactHandlers;
public class CreateContactCommandHandler
{
    private readonly IRepository<Contact> _repository;

    public CreateContactCommandHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateContactCommand command)
    {
        await _repository.CreateAsync(new Contact
        {
            ContactID = command.ContactID,
            Email = command.Email,
            Message = command.Message,
            Name = command.Name,
            SendDate = command.SendDate,
            Subject = command.Subject
        });
    }

}
