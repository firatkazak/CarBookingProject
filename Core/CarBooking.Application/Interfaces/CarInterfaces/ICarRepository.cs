using CarBooking.Domain.Entities;

namespace CarBooking.Application.Interfaces.CarInterfaces;
public interface ICarRepository
{
    List<Car> GetCarsListWithBrands();
    List<Car> GetLast5CarsWithBrands();
    int GetCarCount();
}
