using CarBooking.Application.Features.Mediator.Results.BlogResults;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Queries.BlogQueries;
public class GetAllBlogsWithAuthorQuery : IRequest<List<GetAllBlogsWithAuthorQueryResult>>
{

}
