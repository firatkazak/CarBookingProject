using CarBooking.Application.Features.CQRS.Queries.ContactQueries;
using CarBooking.Application.Features.CQRS.Results.ContactResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;

namespace CarBooking.Application.Features.CQRS.Handlers.ContactHandlers;
public class GetContactByIdQueryHandler
{
    private readonly IRepository<Contact> _repository;

    public GetContactByIdQueryHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
    {
        var values = await _repository.GetByIdAsync(query.Id);
        return new GetContactByIdQueryResult
        {
            ContactID = values.ContactID,
            Email = values.Email,
            Message = values.Message,
            Name = values.Name,
            SendDate = values.SendDate,
            Subject = values.Subject
        };
    }
}
