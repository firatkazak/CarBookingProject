using CarBooking.Application.Features.Mediator.Queries.FooterAddressQueries;
using CarBooking.Application.Features.Mediator.Results.FooterAddressResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.FooterAddressHandlers;
public class GetFooterAddressCommandHandler : IRequestHandler<GetFooterAddressByIdQuery, GetFooterAddressByIdQueryResult>
{
    private readonly IRepository<FooterAddress> _repository;
    public async Task<GetFooterAddressByIdQueryResult> Handle(GetFooterAddressByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.Id);
        return new GetFooterAddressByIdQueryResult
        {
            Address = values.Address,
            Description = values.Description,
            Email = values.Email,
            FooterAddressID = values.FooterAddressID,
            Phone = values.Phone
        };
    }
}
