using CarBooking.Application.Features.Mediator.Queries.TagCloudQueries;
using CarBooking.Application.Features.Mediator.Results.TagCloudResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.TagCloudHandlers;
public class GetPricingByIdQueryHandler : IRequestHandler<GetTagCloudByIdQuery, GetTagCloudByIdQueryResult>
{
    private readonly IRepository<TagCloud> _repository;
    public GetPricingByIdQueryHandler(IRepository<TagCloud> repository)
    {
        _repository = repository;
    }

    public async Task<GetTagCloudByIdQueryResult> Handle(GetTagCloudByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.Id);
        return new GetTagCloudByIdQueryResult
        {
            TagCloudID = values.TagCloudID,
            Title = values.Title,
            BlogID = values.BlogID
        };
    }
}
