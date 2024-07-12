using CarBooking.Application.Features.Mediator.Queries.StatisticQueries;
using CarBooking.Application.Features.Mediator.Results.StatisticResults;
using CarBooking.Application.Interfaces.StatisticInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.StatisticHandlers;
public class GetBlogCountQueryHandler : IRequestHandler<GetBlogCountQuery, GetBlogCountQueryResult>
{
    private readonly IStatisticRepository _repository;

    public GetBlogCountQueryHandler(IStatisticRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetBlogCountQueryResult> Handle(GetBlogCountQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetBlogCount();
        return new GetBlogCountQueryResult
        {
            BlogCount = value
        };
    }
}
