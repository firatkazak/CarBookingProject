using CarBooking.Application.Features.Mediator.Queries.StatisticQueries;
using CarBooking.Application.Features.Mediator.Results.StatisticResults;
using CarBooking.Application.Interfaces.StatisticInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.StatisticHandlers;
public class GetCarCountByTranmissionIsAutoQueryHandler : IRequestHandler<GetCarCountByTranmissionIsAutoQuery, GetCarCountByTranmissionIsAutoQueryResult>
{
    private readonly IStatisticRepository _repository;

    public GetCarCountByTranmissionIsAutoQueryHandler(IStatisticRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetCarCountByTranmissionIsAutoQueryResult> Handle(GetCarCountByTranmissionIsAutoQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetCarCountByTranmissionIsAuto();
        return new GetCarCountByTranmissionIsAutoQueryResult
        {
            CarCountByTranmissionIsAuto = value
        };
    }
}
