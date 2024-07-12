using CarBooking.Application.Features.Mediator.Results.BlogResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.BlogQueries;
public class GetLast3BlogsWithAuthorsQuery : IRequest<List<GetLast3BlogsWithAuthorsQueryResult>>
{
}
