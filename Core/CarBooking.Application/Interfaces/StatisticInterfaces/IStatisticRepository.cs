namespace CarBooking.Application.Interfaces.StatisticInterfaces;
public interface IStatisticRepository
{
    int GetCarCount();
    int GetLocationCount();
    int GetAuthorCount();
    int GetBlogCount();
    int GetBrandCount();
    decimal GetAvgRentPriceForDaily();
    decimal GetAvgRentPriceForWeekly();
    decimal GetAvgRentPriceForMonthly();
    int GetCarCountByTranmissionIsAuto();
    string GetBrandNameByMaxCar();
    string GetBlogTitleByMaxBlogComment();
    int GetCarCountByKmSmallerThen1000();
    int GetCarCountByFuelGasolineOrDiesel();
    int GetCarCountByFuelElectric();
    string GetCarBrandAndModelByRentPriceDailyMax();
    string GetCarBrandAndModelByRentPriceDailyMin();
}
