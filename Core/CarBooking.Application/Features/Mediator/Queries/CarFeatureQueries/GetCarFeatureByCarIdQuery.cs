using CarBooking.Application.Features.Mediator.Results.CarFeatureResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.CarFeatureQueries;
public class GetCarFeatureByCarIdQuery : IRequest<List<GetCarFeatureByCarIdQueryResult>>
{
    public int Id { get; set; }

    public GetCarFeatureByCarIdQuery(int id)
    {
        Id = id;
    }
}
