using CarBooking.Application.Features.Mediator.Results.RentACarResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.RentACarQueries;
public class GetRentACarQuery : IRequest<List<GetRentACarQueryResult>>
{
    public int LocationID { get; set; }
    public bool Available { get; set; }
}
