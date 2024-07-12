using CarBooking.Application.Features.Mediator.Queries.StatisticQueries;
using CarBooking.Application.Features.Mediator.Results.StatisticResults;
using CarBooking.Application.Interfaces.StatisticInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.StatisticHandlers;
public class GetCarCountByFuelElectricQueryHandler : IRequestHandler<GetCarCountByFuelElectricQuery, GetCarCountByFuelElectricQueryResult>
{
    private readonly IStatisticRepository _repository;

    public GetCarCountByFuelElectricQueryHandler(IStatisticRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetCarCountByFuelElectricQueryResult> Handle(GetCarCountByFuelElectricQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetCarCountByFuelElectric();
        return new GetCarCountByFuelElectricQueryResult
        {
            CarCountByFuelElectric = value
        };
    }
}
