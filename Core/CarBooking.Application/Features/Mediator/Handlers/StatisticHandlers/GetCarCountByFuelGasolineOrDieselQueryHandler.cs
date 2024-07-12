using CarBooking.Application.Features.Mediator.Queries.StatisticQueries;
using CarBooking.Application.Features.Mediator.Results.StatisticResults;
using CarBooking.Application.Interfaces.StatisticInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.StatisticHandlers;
public class GetCarCountByFuelGasolineOrDieselQueryHandler : IRequestHandler<GetCarCountByFuelGasolineOrDieselQuery, GetCarCountByFuelGasolineOrDieselQueryResult>
{
    private readonly IStatisticRepository _repository;

    public GetCarCountByFuelGasolineOrDieselQueryHandler(IStatisticRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetCarCountByFuelGasolineOrDieselQueryResult> Handle(GetCarCountByFuelGasolineOrDieselQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetCarCountByFuelGasolineOrDiesel();
        return new GetCarCountByFuelGasolineOrDieselQueryResult
        {
            CarCountByFuelGasolineOrDiesel = value
        };
    }
}
