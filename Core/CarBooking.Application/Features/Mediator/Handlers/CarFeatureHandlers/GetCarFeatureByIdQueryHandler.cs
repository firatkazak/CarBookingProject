using CarBooking.Application.Features.Mediator.Queries.CarFeatureQueries;
using CarBooking.Application.Features.Mediator.Results.CarFeatureResults;
using CarBooking.Application.Interfaces.CarFeatureInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.CarFeatureHandlers;
public class GetCarFeatureByCarIdQueryHandler : IRequestHandler<GetCarFeatureByCarIdQuery, List<GetCarFeatureByCarIdQueryResult>>
{
    private readonly ICarFeatureRepository _repository;
    public GetCarFeatureByCarIdQueryHandler(ICarFeatureRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetCarFeatureByCarIdQueryResult>> Handle(GetCarFeatureByCarIdQuery request, CancellationToken cancellationToken)
    {
        var values = _repository.GetCarFeaturesByCarID(request.Id);
        return values.Select(x => new GetCarFeatureByCarIdQueryResult
        {
            Available = x.Available,
            CarFeatureID = x.CarFeatureID,
            FeatureID = x.FeatureID,
            FeatureName = x.Feature.Name
        }).ToList();
    }
}
