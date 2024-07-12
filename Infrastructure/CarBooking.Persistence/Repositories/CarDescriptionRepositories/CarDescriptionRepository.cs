using CarBooking.Application.Interfaces.CarDescriptionInterfaces;
using CarBooking.Domain.Entities;
using CarBooking.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBooking.Persistence.Repositories.CarDescriptionRepositories;
public class CarDescriptionRepository : ICarDescriptionRepository
{
	private readonly CarBookingContext _context;

	public CarDescriptionRepository(CarBookingContext context)
	{
		_context = context;
	}

	async Task<CarDescription> ICarDescriptionRepository.GetCarDescription(int carId)
	{
		var values = await _context.CarDescriptions.Where(x => x.CarID == carId).FirstOrDefaultAsync();
		return values;
	}
}
