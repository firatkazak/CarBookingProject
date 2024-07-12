using CarBooking.Application.Features.Mediator.Queries.StatisticQueries;
using CarBooking.Application.Features.Mediator.Results.StatisticResults;
using CarBooking.Application.Interfaces.CarInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.StatisticHandlers;
public class GetCarCountQueryHandler : IRequestHandler<GetCarCountQuery, GetCarCountQueryResult>
{
    private readonly ICarRepository _repository;

    public GetCarCountQueryHandler(ICarRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetCarCountQueryResult> Handle(GetCarCountQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetCarCount();
        return new GetCarCountQueryResult
        {
            CarCount = value,
        };
    }
}
