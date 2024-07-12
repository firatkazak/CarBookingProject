using CarBooking.Application.Features.Mediator.Queries.ServiceQueries;
using CarBooking.Application.Features.Mediator.Results.ServiceResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.ServiceHandlers;
public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
{
    private readonly IRepository<Service> _repository;

    public GetServiceQueryHandler(IRepository<Service> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetServiceQueryResult
        {
            Description = x.Description,
            IconUrl = x.IconUrl,
            ServiceID = x.ServiceID,
            Title = x.Title
        }).ToList();
    }
}
