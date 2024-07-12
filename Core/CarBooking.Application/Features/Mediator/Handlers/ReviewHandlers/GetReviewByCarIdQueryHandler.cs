using CarBooking.Application.Features.Mediator.Queries.ReviewQueries;
using CarBooking.Application.Features.Mediator.Results.ReviewResults;
using CarBooking.Application.Interfaces.ReviewInterfaces;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.ReviewHandlers;
public class GetReviewByCarIdQueryHandler : IRequestHandler<GetReviewByCarIdQuery, List<GetReviewByCarIdQueryResult>>
{
	private readonly IReviewRepository _repository;
	public GetReviewByCarIdQueryHandler(IReviewRepository repository)
	{
		_repository = repository;
	}

	public async Task<List<GetReviewByCarIdQueryResult>> Handle(GetReviewByCarIdQuery request, CancellationToken cancellationToken)
	{
		var values = _repository.GetReviewsByCarId(request.Id);
		return values.Select(x => new GetReviewByCarIdQueryResult
		{
			CarID = x.CarID,
			Comment = x.Comment,
			CustomerImage = x.CustomerImage,
			CustomerName = x.CustomerName,
			RaytingValue = x.RaytingValue,
			ReviewDate = x.ReviewDate,
			ReviewID = x.ReviewID
		}).ToList();
	}
}
