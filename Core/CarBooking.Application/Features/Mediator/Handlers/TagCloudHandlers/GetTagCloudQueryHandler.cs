using CarBooking.Application.Features.Mediator.Queries.TagCloudQueries;
using CarBooking.Application.Features.Mediator.Results.TagCloudResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.TagCloudHandlers;
public class GetServiceQueryHandler : IRequestHandler<GetTagCloudQuery, List<GetTagCloudQueryResult>>
{
    private readonly IRepository<TagCloud> _repository;
    public GetServiceQueryHandler(IRepository<TagCloud> repository)
    {
        _repository = repository;
    }
    public async Task<List<GetTagCloudQueryResult>> Handle(GetTagCloudQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetTagCloudQueryResult
        {
            Title = x.Title,
            TagCloudID = x.TagCloudID,
            BlogID = x.BlogID
        }).ToList();
    }
}
