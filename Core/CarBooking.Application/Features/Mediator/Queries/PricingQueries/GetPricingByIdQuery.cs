using CarBooking.Application.Features.Mediator.Results.PricingResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.PricingQueries;
public class GetPricingByIdQuery : IRequest<GetPricingByIdQueryResult>
{
    public GetPricingByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
