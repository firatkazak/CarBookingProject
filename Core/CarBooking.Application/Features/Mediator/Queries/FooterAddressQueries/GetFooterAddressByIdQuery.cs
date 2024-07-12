using CarBooking.Application.Features.Mediator.Results.FooterAddressResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.FooterAddressQueries;
public class GetFooterAddressByIdQuery : IRequest<GetFooterAddressByIdQueryResult>
{
    public GetFooterAddressByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
