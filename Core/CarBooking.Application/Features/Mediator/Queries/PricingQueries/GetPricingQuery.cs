using CarBooking.Application.Features.Mediator.Results.PricingResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.PricingQueries;
public class GetPricingQuery : IRequest<List<GetPricingQueryResult>>
{

}
