using CarBooking.Application.Features.Mediator.Results.CarDescriptionResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.CarDescriptionQueries;
public class GetCarDescriptionByCarIdQuery : IRequest<GetCarDescriptionQueryResult>
{
	public int Id { get; set; }

	public GetCarDescriptionByCarIdQuery(int id)
	{
		Id = id;
	}
}