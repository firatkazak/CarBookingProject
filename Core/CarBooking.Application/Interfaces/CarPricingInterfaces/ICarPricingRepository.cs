using CarBooking.Application.ViewModels;
using CarBooking.Domain.Entities;

namespace CarBooking.Application.Interfaces.CarPricingInterfaces;
public interface ICarPricingRepository
{
    List<CarPricing> GetCarPricingWithCars();
    List<CarPricing> GetCarPricingWithTimePeriod();
    List<CarPricingViewModel> GetCarPricingWithTimePeriodVM();
}
