using CarBooking.Application.Features.Mediator.Queries.StatisticQueries;
using CarBooking.Application.Features.Mediator.Results.StatisticResults;
using CarBooking.Application.Interfaces.StatisticInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.StatisticHandlers;
public class GetBlogTitleByMaxBlogCommentQueryHandler : IRequestHandler<GetBlogTitleByMaxBlogCommentQuery, GetBlogTitleByMaxBlogCommentQueryResult>
{
    private readonly IStatisticRepository _repository;

    public GetBlogTitleByMaxBlogCommentQueryHandler(IStatisticRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetBlogTitleByMaxBlogCommentQueryResult> Handle(GetBlogTitleByMaxBlogCommentQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetBlogTitleByMaxBlogComment();
        return new GetBlogTitleByMaxBlogCommentQueryResult
        {
            BlogTitleByMaxBlogComment = value
        };
    }
}
