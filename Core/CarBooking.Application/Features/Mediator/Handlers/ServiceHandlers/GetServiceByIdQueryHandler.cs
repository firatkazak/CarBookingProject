using CarBooking.Application.Features.Mediator.Queries.ServiceQueries;
using CarBooking.Application.Features.Mediator.Results.ServiceResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.ServiceHandlers;
public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
{
    private readonly IRepository<Service> _repository;

    public GetServiceByIdQueryHandler(IRepository<Service> repository)
    {
        _repository = repository;
    }

    public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.Id);
        return new GetServiceByIdQueryResult
        {
            Description = values.Description,
            IconUrl = values.IconUrl,
            ServiceID = values.ServiceID,
            Title = values.Title
        };
    }
}
