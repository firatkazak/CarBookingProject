using CarBooking.Application.Features.Mediator.Results.ServiceResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.ServiceQueries;
public class GetServiceQuery : IRequest<List<GetServiceQueryResult>>
{

}
