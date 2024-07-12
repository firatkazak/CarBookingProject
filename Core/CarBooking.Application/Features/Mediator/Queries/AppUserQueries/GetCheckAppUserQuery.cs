using CarBooking.Application.Features.Mediator.Results.AppUserResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.AppUserQueries;
public class GetCheckAppUserQuery : IRequest<GetCheckAppUserQueryResult>
{
	public string Username { get; set; }
	public string Password { get; set; }
}