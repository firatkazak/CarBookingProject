using CarBooking.Application.Features.Mediator.Queries.FeatureQueries;
using CarBooking.Application.Features.Mediator.Results.FeatureResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.FeatureHandlers;
public class GetFeatureByIdQueryHandler : IRequestHandler<GetFeatureByIdQuery, GetFeatureByIdQueryResult>
{
    private readonly IRepository<Feature> _repository;
    public GetFeatureByIdQueryHandler(IRepository<Feature> repository)
    {
        _repository = repository;
    }

    public async Task<GetFeatureByIdQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.Id);
        return new GetFeatureByIdQueryResult
        {
            FeatureID = values.FeatureID,
            Name = values.Name
        };
    }
}
