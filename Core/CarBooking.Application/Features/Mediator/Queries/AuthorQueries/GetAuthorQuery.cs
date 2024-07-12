using CarBooking.Application.Features.Mediator.Results.AuthorResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.AuthorQueries;
public class GetAuthorQuery : IRequest<List<GetAuthorQueryResult>>
{

}
