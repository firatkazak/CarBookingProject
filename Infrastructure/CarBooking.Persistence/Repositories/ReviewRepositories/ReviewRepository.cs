using CarBooking.Application.Interfaces.ReviewInterfaces;
using CarBooking.Domain.Entities;
using CarBooking.Persistence.Context;

namespace CarBooking.Persistence.Repositories.ReviewRepositories;
public class ReviewRepository : IReviewRepository
{
	private readonly CarBookingContext _context;

	public ReviewRepository(CarBookingContext context)
	{
		_context = context;
	}

	public List<Review> GetReviewsByCarId(int carId)
	{
		var values = _context.Reviews.Where(x => x.CarID == carId).ToList();
		return values;
	}
}
