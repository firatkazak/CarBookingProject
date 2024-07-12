using CarBooking.Application.Features.Mediator.Commands.ReviewCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;

namespace CarBooking.Application.Features.Mediator.Handlers.ReviewHandlers;
public class UpdateReviewHandler : IRequestHandler<UpdateReviewCommand>
{
	private readonly IRepository<Review> _repository;
	public UpdateReviewHandler(IRepository<Review> repository)
	{
		_repository = repository;
	}
	public async Task Handle(UpdateReviewCommand request, CancellationToken cancellationToken)
	{
		var values = await _repository.GetByIdAsync(request.ReviewId);
		values.CustomerName = request.CustomerName;
		values.ReviewDate = request.ReviewDate;
		values.CarID = request.CarID;
		values.Comment = request.Comment;
		values.RaytingValue = request.RaytingValue;
		await _repository.UpdateAsync(values);
	}
}
