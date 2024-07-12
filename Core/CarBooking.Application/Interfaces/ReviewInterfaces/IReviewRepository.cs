using CarBooking.Domain.Entities;

namespace CarBooking.Application.Interfaces.ReviewInterfaces;
public interface IReviewRepository
{
	public List<Review> GetReviewsByCarId(int carId);
}
