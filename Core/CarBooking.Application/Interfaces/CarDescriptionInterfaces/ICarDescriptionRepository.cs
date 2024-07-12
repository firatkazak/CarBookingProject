using CarBooking.Domain.Entities;

namespace CarBooking.Application.Interfaces.CarDescriptionInterfaces;
public interface ICarDescriptionRepository
{
	Task<CarDescription> GetCarDescription(int carId);
}
