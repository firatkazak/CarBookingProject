using CarBooking.Application.Interfaces.CarFeatureInterfaces;
using CarBooking.Domain.Entities;
using CarBooking.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBooking.Persistence.Repositories.CarFeatureRepositories;
public class CarFeatureRepository : ICarFeatureRepository
{
    private readonly CarBookingContext _context;
    public CarFeatureRepository(CarBookingContext context)
    {
        _context = context;
    }

    public void ChangeCarFeatureAvailableToFalse(int id)
    {
        var values = _context.CarFeatures.Where(x => x.CarFeatureID == id).FirstOrDefault();
        values.Available = false;
        _context.SaveChanges();
    }

    public void ChangeCarFeatureAvailableToTrue(int id)
    {
        var values = _context.CarFeatures.Where(x => x.CarFeatureID == id).FirstOrDefault();
        values.Available = true;
        _context.SaveChanges();
    }

    public void CreateCarFeatureByCar(CarFeature carFeature)
    {
        _context.CarFeatures.Add(carFeature);
        _context.SaveChanges();
    }

    public List<CarFeature> GetCarFeaturesByCarID(int carID)
    {
        var values = _context.CarFeatures.Include(y => y.Feature).Where(x => x.CarID == carID).ToList();
        return values;
    }
}
