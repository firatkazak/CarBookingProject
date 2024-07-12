using CarBooking.Application.Interfaces.CarInterfaces;
using CarBooking.Domain.Entities;
using CarBooking.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBooking.Persistence.Repositories.CarRepositories;
public class CarRepository : ICarRepository
{
    private readonly CarBookingContext _context;

    public CarRepository(CarBookingContext context)
    {
        _context = context;
    }

    public int GetCarCount()
    {
        var value = _context.Cars.Count();
        return value;
    }

    public List<Car> GetCarsListWithBrands()
    {
        var values = _context.Cars.Include(x => x.Brand).ToList();
        return values;
    }

    public List<Car> GetLast5CarsListWithBrands()
    {
        var values = _context.Cars.Include(_x => _x.Brand).OrderByDescending(x => x.CarID).Take(5).ToList();
        return values;
    }

    public List<Car> GetLast5CarsWithBrands()
    {
        var values = _context.Cars.Include(x => x.Brand).OrderByDescending(x => x.CarID).Take(5).ToList();
        return values;
    }
}
