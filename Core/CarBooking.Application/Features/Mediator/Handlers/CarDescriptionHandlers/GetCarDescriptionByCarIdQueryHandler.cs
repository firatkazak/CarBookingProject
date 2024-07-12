using CarBooking.Application.Features.Mediator.Queries.CarDescriptionQueries;
using CarBooking.Application.Features.Mediator.Results.CarDescriptionResults;
using CarBooking.Application.Interfaces.CarDescriptionInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.CarDescriptionHandlers;
public class GetCarDescriptionByCarIdQueryHandler : IRequestHandler<GetCarDescriptionByCarIdQuery, GetCarDescriptionQueryResult>
{
	private readonly ICarDescriptionRepository _repository;
	public GetCarDescriptionByCarIdQueryHandler(ICarDescriptionRepository repository)
	{
		_repository = repository;
	}

	public async Task<GetCarDescriptionQueryResult> Handle(GetCarDescriptionByCarIdQuery request, CancellationToken cancellationToken)
	{
		var values = await _repository.GetCarDescription(request.Id);
		return new GetCarDescriptionQueryResult
		{
			CarDescriptionID = values.CarDescriptionID,
			CarID = values.CarID,
			Details = values.Details
		};
	}
}
