using CarBooking.Application.Features.Mediator.Results.ServiceResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.ServiceQueries;
public class GetServiceByIdQuery : IRequest<GetServiceByIdQueryResult>
{
    public GetServiceByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
