using CarBooking.Application.Features.Mediator.Queries.StatisticQueries;
using CarBooking.Application.Features.Mediator.Results.StatisticResults;
using CarBooking.Application.Interfaces.StatisticInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.StatisticHandlers;
public class GetBrandCountQueryHandler : IRequestHandler<GetBrandCountQuery, GetBrandCountQueryResult>
{
    private readonly IStatisticRepository _repository;

    public GetBrandCountQueryHandler(IStatisticRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetBrandCountQueryResult> Handle(GetBrandCountQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetBrandCount();
        return new GetBrandCountQueryResult
        {
            BrandCount = value
        };
    }
}
