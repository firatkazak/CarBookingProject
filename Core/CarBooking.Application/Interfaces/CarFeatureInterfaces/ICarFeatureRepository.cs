using CarBooking.Domain.Entities;

namespace CarBooking.Application.Interfaces.CarFeatureInterfaces;
public interface ICarFeatureRepository
{
    List<CarFeature> GetCarFeaturesByCarID(int carID);
    void ChangeCarFeatureAvailableToFalse(int id);
    void ChangeCarFeatureAvailableToTrue(int id);
    void CreateCarFeatureByCar(CarFeature carFeature);
}
