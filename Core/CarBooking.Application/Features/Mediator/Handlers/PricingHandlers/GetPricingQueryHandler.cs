using CarBooking.Application.Features.Mediator.Queries.PricingQueries;
using CarBooking.Application.Features.Mediator.Results.PricingResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.PricingHandlers;
public class GetPricingQueryHandler : IRequestHandler<GetPricingQuery, List<GetPricingQueryResult>>
{
    private readonly IRepository<Pricing> _repository;

    public GetPricingQueryHandler(IRepository<Pricing> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetPricingQueryResult>> Handle(GetPricingQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetPricingQueryResult
        {
            PricingID = x.PricingID,
            Name = x.Name
        }).ToList();
    }
}
